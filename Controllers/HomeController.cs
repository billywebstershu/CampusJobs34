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
                var command = _dbConnection.CreateCommand();
                command.CommandText = "SELECT 1"; 
                command.ExecuteScalar();
                connectionSuccessful = true;
                _dbConnection.Close();
            }
            catch
            {
                connectionSuccessful = false;
            }
            finally
            {
                if (_dbConnection.State == ConnectionState.Open)
                {
                    _dbConnection.Close(); 
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
