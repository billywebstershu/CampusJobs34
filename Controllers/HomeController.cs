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
            // Example query
            _dbConnection.Open();
            var command = _dbConnection.CreateCommand();
            command.CommandText = "SELECT * FROM Users";
            var reader = command.ExecuteReader();

            // Process the data...
            while (reader.Read())
            {
                var userId = reader["User_ID"].ToString();
                // Do something with the data...
            }

            _dbConnection.Close();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
