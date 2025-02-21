using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using MySql.Data.MySqlClient;
using CampusJobsProject___Group_34.Models;

namespace CampusJobsProject___Group_34.Controllers
{
    public class AccountController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public AccountController(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

       
        [HttpGet]
        public IActionResult Login()
        {
           
            HttpContext.Session.Clear();
            return View();
        }

       
        [HttpPost]
        public IActionResult Login(string email, string password, string role)
        {
            
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ViewBag.Error = "Email and password are required.";
                return View();
            }

            
            if (role != "Student")
            {
                ViewBag.Error = "Access denied. Only students can login.";
                return View();
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = @"SELECT User_ID, First_Name, Last_Name 
                                 FROM Users 
                                 WHERE Email = @Email 
                                 AND Password = @Password 
                                 AND Role = 1";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               
                                HttpContext.Session.SetInt32("UserId", reader.GetInt32("User_ID"));
                                HttpContext.Session.SetString("FirstName", reader.GetString("First_Name"));
                                HttpContext.Session.SetString("LastName", reader.GetString("Last_Name"));
                                HttpContext.Session.SetString("Role", "Student");

                                // Redirect to student homepage
                                return RedirectToAction("Index", "Homepage");
                            }
                            else
                            {
                                ViewBag.Error = "Invalid email or password.";
                                return View();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                ViewBag.Error = "An error occurred while logging in.";
                return View();
            }
        }

        [HttpGet]
        public IActionResult Logout()
        {
            
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        
        private bool IsAuthenticated()
        {
            return HttpContext.Session.GetInt32("UserId").HasValue;
        }
    }
}
