using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;

namespace CampusJobsProject___Group_34.Controllers
{
    public class AccountController : Controller
    {
        private readonly IConfiguration _configuration;

        public AccountController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(string email, string password, string role)
        {
            // 1. Get the connection string
            string connectionString = _configuration.GetConnectionString("DefaultConnection");

            // 2. Connect to the database
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // 3. Query the Users table for a matching Email, Password, and Role
                string query = @"SELECT Role 
                                 FROM Users 
                                 WHERE Email = @Email 
                                   AND Password = @Password 
                                   AND Role = @Role";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role);

                    var roleObj = cmd.ExecuteScalar();
                    if (roleObj != null)
                    {
                        // Found a match in the DB
                        string foundRole = roleObj.ToString();

                        // 4. Redirect based on role
                        if (foundRole.Equals("Student", StringComparison.OrdinalIgnoreCase))
                        {
                            return RedirectToAction("Index", "Student");
                        }
                        else if (foundRole.Equals("Recruiter", StringComparison.OrdinalIgnoreCase))
                        {
                            return RedirectToAction("Index", "Recruiter");
                        }
                        else if (foundRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                        {
                            return RedirectToAction("Index", "Admin");
                        }
                        else
                        {
                            ViewBag.Error = "Unknown role in database.";
                            return View();
                        }
                    }
                    else
                    {
                        ViewBag.Error = "Invalid email, password, or role.";
                        return View();
                    }
                }
            }
        }
    }
}