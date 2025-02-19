using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CampusJobsProject___Group_34.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDbConnection _dbConnection;

        public HomeController(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IActionResult Index()
        {
            bool connectionSuccessful = false;
            try
            {
                _dbConnection.Open();
                //if the connection opens succesfully, set command to a basic query
                var command = _dbConnection.CreateCommand();
                command.CommandText = "SELECT 1"; // A simple query to check connection
                command.ExecuteScalar();
                connectionSuccessful = true;
                _dbConnection.Close();
            }
            catch
            {
                // If any exception occurs during the connection or query, it's considered a failure.
                connectionSuccessful = false;
            }
            finally
            {
                if (_dbConnection.State == ConnectionState.Open)
                {
                    _dbConnection.Close(); // Ensure connection is closed in all cases
                }
            }

            ViewBag.DatabaseStatus = connectionSuccessful ? "Database connection successful!" : "Database connection failed.";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
