using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Student_Dashboard.Models;

namespace Student_Dashboard.Controllers
{
    public class TimeSheetsController : Controller
    {
        public ActionResult Index()
        {
            var timesheets = new List<TimeSheet>
{
    new TimeSheet
    {
        Date = DateTime.Parse("2025-02-19"),
        ShiftId = "S001",
        AvailableShifts = "Morning",
        StartTime = DateTime.Parse("08:00"),
        EndTime = DateTime.Parse("12:00"),
        TotalHours = 4,
        Recruiter = "John Doe"
    },
    new TimeSheet
    {
        Date = DateTime.Parse("2025-02-20"),
        ShiftId = "S002",
        AvailableShifts = "Evening",
        StartTime = DateTime.Parse("16:00"),
        EndTime = DateTime.Parse("20:00"),
        TotalHours = 4,
        Recruiter = "Jane Doe"
    },
    new TimeSheet
    {
        Date = DateTime.Parse("2025-02-21"),
        ShiftId = "S003",
        AvailableShifts = "Night",
        StartTime = DateTime.Parse("22:00"),
        EndTime = DateTime.Parse("06:00"),
        TotalHours = 8,
        Recruiter = "Alice Smith"
    },
    new TimeSheet
    {
        Date = DateTime.Parse("2025-02-22"),
        ShiftId = "S004",
        AvailableShifts = "Morning",
        StartTime = DateTime.Parse("08:00"),
        EndTime = DateTime.Parse("12:00"),
        TotalHours = 4,
        Recruiter = "Bob Johnson"
    },
    new TimeSheet
    {
        Date = DateTime.Parse("2025-02-23"),
        ShiftId = "S005",
        AvailableShifts = "Evening",
        StartTime = DateTime.Parse("16:00"),
        EndTime = DateTime.Parse("20:00"),
        TotalHours = 4,
        Recruiter = "Charlie Brown"
    },
    new TimeSheet
    {
        Date = DateTime.Parse("2025-02-24"),
        ShiftId = "S006",
        AvailableShifts = "Night",
        StartTime = DateTime.Parse("22:00"),
        EndTime = DateTime.Parse("06:00"),
        TotalHours = 8,
        Recruiter = "Diana Evans"
    },
    new TimeSheet
    {
        Date = DateTime.Parse("2025-02-25"),
        ShiftId = "S007",
        AvailableShifts = "Morning",
        StartTime = DateTime.Parse("08:00"),
        EndTime = DateTime.Parse("12:00"),
        TotalHours = 4,
        Recruiter = "Ethan Harris"
    },
    new TimeSheet
    {
        Date = DateTime.Parse("2025-02-26"),
        ShiftId = "S008",
        AvailableShifts = "Evening",
        StartTime = DateTime.Parse("16:00"),
        EndTime = DateTime.Parse("20:00"),
        TotalHours = 4,
        Recruiter = "Fiona Clark"
    },
    new TimeSheet
    {
        Date = DateTime.Parse("2025-02-27"),
        ShiftId = "S009",
        AvailableShifts = "Night",
        StartTime = DateTime.Parse("22:00"),
        EndTime = DateTime.Parse("06:00"),
        TotalHours = 8,
        Recruiter = "George Lewis"
    },
    new TimeSheet
    {
        Date = DateTime.Parse("2025-02-28"),
        ShiftId = "S010",
        AvailableShifts = "Morning",
        StartTime = DateTime.Parse("08:00"),
        EndTime = DateTime.Parse("12:00"),
        TotalHours = 4,
        Recruiter = "Hannah Walker"
    },
    new TimeSheet
    {
        Date = DateTime.Parse("2025-03-01"),
        ShiftId = "S011",
        AvailableShifts = "Evening",
        StartTime = DateTime.Parse("16:00"),
        EndTime = DateTime.Parse("20:00"),
        TotalHours = 4,
        Recruiter = "Ian Hall"
    },
    new TimeSheet
    {
        Date = DateTime.Parse("2025-03-02"),
        ShiftId = "S012",
        AvailableShifts = "Night",
        StartTime = DateTime.Parse("22:00"),
        EndTime = DateTime.Parse("06:00"),
        TotalHours = 8,
        Recruiter = "Julia Young"
    },
    new TimeSheet
    {
        Date = DateTime.Parse("2025-03-03"),
        ShiftId = "S013",
        AvailableShifts = "Morning",
        StartTime = DateTime.Parse("08:00"),
        EndTime = DateTime.Parse("12:00"),
        TotalHours = 4,
        Recruiter = "Kevin King"
    },
    new TimeSheet
    {
        Date = DateTime.Parse("2025-03-04"),
        ShiftId = "S014",
        AvailableShifts = "Evening",
        StartTime = DateTime.Parse("16:00"),
        EndTime = DateTime.Parse("20:00"),
        TotalHours = 4,
        Recruiter = "Laura Scott"
    },
    new TimeSheet
    {
        Date = DateTime.Parse("2025-03-05"),
        ShiftId = "S015",
        AvailableShifts = "Night",
        StartTime = DateTime.Parse("22:00"),
        EndTime = DateTime.Parse("06:00"),
        TotalHours = 8,
        Recruiter = "Michael Green"
    },
    new TimeSheet
    {
        Date = DateTime.Parse("2025-03-06"),
        ShiftId = "S016",
        AvailableShifts = "Morning",
        StartTime = DateTime.Parse("08:00"),
        EndTime = DateTime.Parse("12:00"),
        TotalHours = 4,
        Recruiter = "Natalie Adams"
    },
    new TimeSheet
    {
        Date = DateTime.Parse("2025-03-07"),
        ShiftId = "S017",
        AvailableShifts = "Evening",
        StartTime = DateTime.Parse("16:00"),
        EndTime = DateTime.Parse("20:00"),
        TotalHours = 4,
        Recruiter = "Oliver Wright"
    },
    new TimeSheet
    {
        Date = DateTime.Parse("2025-03-08"),
        ShiftId = "S018",
        AvailableShifts = "Night",
        StartTime = DateTime.Parse("22:00"),
        EndTime = DateTime.Parse("06:00"),
        TotalHours = 8,
        Recruiter = "Paula Martinez"
    },
    new TimeSheet
    {
        Date = DateTime.Parse("2025-03-09"),
        ShiftId = "S019",
        AvailableShifts = "Morning",
        StartTime = DateTime.Parse("08:00"),
        EndTime = DateTime.Parse("12:00"),
        TotalHours = 4,
        Recruiter = "Quincy Turner"
    },
    new TimeSheet
    {
        Date = DateTime.Parse("2025-03-10"),
        ShiftId = "S020",
        AvailableShifts = "Evening",
        StartTime = DateTime.Parse("16:00"),
        EndTime = DateTime.Parse("20:00"),
        TotalHours = 4,
        Recruiter = "Rachel White"
    }
};

            return View(timesheets);
        }
    }
}
