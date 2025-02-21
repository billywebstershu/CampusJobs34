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

       
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

       
        [HttpPost]
        public IActionResult Login(string email, string password, string role)
        {
           
            string connectionString = _configuration.GetConnectionString("DefaultConnection");

           
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

               
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
                        
                        string foundRole = roleObj.ToString();

                       
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
