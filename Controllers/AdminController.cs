using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using CampusJobsProject___Group_34.Models;

namespace CampusJobsProject___Group_34.Controllers {
  public class AdminController: Controller {
    private readonly string _connectionString;

    public AdminController(IConfiguration configuration) {
      _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    [HttpPost]
    public IActionResult SearchUser(int userId) {
      UserModel user = null;
      try {
        using(MySqlConnection connection = new MySqlConnection(_connectionString)) {
          connection.Open();
          string sql = "SELECT User_ID, First_Name, Last_Name, Email, Role, Address FROM Users WHERE User_ID = @UserId";
          using(MySqlCommand command = new MySqlCommand(sql, connection)) {
            command.Parameters.AddWithValue("@UserId", userId);

            using(MySqlDataReader reader = command.ExecuteReader()) {
              if (reader.Read()) {
                user = new UserModel {
                  User_ID = reader.GetInt32("User_ID"),
                    First_Name = reader.GetString("First_Name"),
                    Last_Name = reader.GetString("Last_Name"),
                    Email = reader.GetString("Email"),
                    Role = reader.GetInt32("Role"),
                    Address = reader.IsDBNull(reader.GetOrdinal("Address")) ? null : reader.GetString("Address")
                };
              }
            }
          }
        }
      } catch (Exception ex) {
        ViewBag.ErrorMessage = "Error retrieving user: " + ex.Message;
        return View("Index");
      }

      if (user == null) {
        ViewBag.ErrorMessage = "User not found.";
        return View("Index");
      }

      return View("Index", new List < UserModel > {
        user
      });
    }

    public IActionResult EditUser(int id) {
      UserModel user = null;
      try {
        using(MySqlConnection connection = new MySqlConnection(_connectionString)) {
          connection.Open();
          string sql = "SELECT User_ID, First_Name, Last_Name, Email, Role, Address FROM Users WHERE User_ID = @UserId";
          using(MySqlCommand command = new MySqlCommand(sql, connection)) {
            command.Parameters.AddWithValue("@UserId", id);

            using(MySqlDataReader reader = command.ExecuteReader()) {
              if (reader.Read()) {
                user = new UserModel {
                  User_ID = reader.GetInt32("User_ID"),
                    First_Name = reader.GetString("First_Name"),
                    Last_Name = reader.GetString("Last_Name"),
                    Email = reader.GetString("Email"),
                    Role = reader.GetInt32("Role"),
                    Address = reader.IsDBNull(reader.GetOrdinal("Address")) ? null : reader.GetString("Address")
                };
              }
            }
          }
        }
      } catch (Exception ex) {
        ViewBag.ErrorMessage = "Error retrieving user: " + ex.Message;
        return View("Index");
      }

      if (user == null) {
        ViewBag.ErrorMessage = "User not found.";
        return View("Index");
      }

      return View("EditUser", user);
    }

    [HttpPost]
    public IActionResult UpdateUser(UserModel user) {
      try {
        using(MySqlConnection connection = new MySqlConnection(_connectionString)) {
          connection.Open();
          string sql = "UPDATE Users SET First_Name = @FirstName, Last_Name = @LastName, Email = @Email, Role = @Role, Address = @Address WHERE User_ID = @UserId";

          using(MySqlCommand command = new MySqlCommand(sql, connection)) {
            command.Parameters.AddWithValue("@UserId", user.User_ID);
            command.Parameters.AddWithValue("@FirstName", user.First_Name);
            command.Parameters.AddWithValue("@LastName", user.Last_Name);
            command.Parameters.AddWithValue("@Email", user.Email);
            command.Parameters.AddWithValue("@Role", user.Role);
            command.Parameters.AddWithValue("@Address", (object) user.Address ?? DBNull.Value);

            command.ExecuteNonQuery();
          }
        }
      } catch (Exception ex) {
        ViewBag.ErrorMessage = "Error updating user: " + ex.Message;
        return View("EditUser", user);
      }

      return RedirectToAction("Index");
    }

    public IActionResult Index() {
      List < UserModel > users = new List < UserModel > ();

      try {
        using(MySqlConnection connection = new MySqlConnection(_connectionString)) {
          connection.Open();
          string sql = "SELECT User_ID, First_Name, Last_Name, Email, Role, Address FROM Users";
          using(MySqlCommand command = new MySqlCommand(sql, connection)) {
            using(MySqlDataReader reader = command.ExecuteReader()) {
              while (reader.Read()) {
                users.Add(new UserModel {
                  User_ID = reader.GetInt32("User_ID"),
                    First_Name = reader.GetString("First_Name"),
                    Last_Name = reader.GetString("Last_Name"),
                    Email = reader.GetString("Email"),
                    Role = reader.GetInt32("Role"),
                    Address = reader.IsDBNull(reader.GetOrdinal("Address")) ? null : reader.GetString("Address")
                });
              }
            }
          }
        }
      } catch (Exception ex) {
        ViewBag.ErrorMessage = "Error retrieving users: " + ex.Message;
      }

      return View(users);
    }

    [HttpPost]
    public IActionResult DeleteUser(int id) {
      try {
        using(MySqlConnection connection = new MySqlConnection(_connectionString)) {
          connection.Open();
          string sql = "DELETE FROM Users WHERE User_ID = @UserId";

          using(MySqlCommand command = new MySqlCommand(sql, connection)) {
            command.Parameters.AddWithValue("@UserId", id);
            command.ExecuteNonQuery();
          }
        }
      } catch (Exception ex) {
        ViewBag.ErrorMessage = "Error deleting user: " + ex.Message;
      }

      return RedirectToAction("Index");
    }
  }
}
