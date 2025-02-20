using Microsoft.AspNetCore.Mvc;
using System.Data;
using MySql.Data.MySqlClient; 
using CampusJobsProject___Group_34.Models;

namespace CampusJobsProject___Group_34.Controllers
{
    public class AdminController : Controller
    {
        private readonly string _connectionString;  

        public AdminController(IConfiguration configuration) 
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public IActionResult Index()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult SearchUser(int userId)
        {
            UserModel user = null;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "SELECT User_ID, First_Name, Last_Name, Email, Role, Address FROM Users WHERE User_ID = @UserId";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new UserModel
                                {
                                    UserId = reader.GetInt32("User_ID"),
                                    FirstName = reader.GetString("First_Name"),
                                    LastName = reader.GetString("Last_Name"),
                                    Email = reader.GetString("Email"),
                                    Role = reader.GetString("Role"),
                                    Address = reader.IsDBNull(reader.GetOrdinal("Address")) ? null : reader.GetString("Address")
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Error retrieving user: " + ex.Message;  
                return View("Index"); 
            }
            if (user == null)
            {
                ViewBag.ErrorMessage = "User not found.";
                return View("Index");
            }

            return View("Index", user); 
        }
    }
}
