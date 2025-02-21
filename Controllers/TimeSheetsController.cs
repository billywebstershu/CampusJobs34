using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using CampusJobsProject___Group_34.Models;

namespace CampusJobsProject___Group_34.Controllers
{
    public class TimeSheetsController : Controller
    {
        public ActionResult Index()
        {
            var timesheets = new List<TimesheetModel>
            {
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-02-19"), Timesheet_ID = 1, Hours_Worked = 4, Recruitment_ID = 20 },
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-02-20"), Timesheet_ID = 2, Hours_Worked = 4, Recruitment_ID = 19 },
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-02-21"), Timesheet_ID = 3, Hours_Worked = 8, Recruitment_ID = 18 },
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-02-22"), Timesheet_ID = 4, Hours_Worked = 4, Recruitment_ID = 17 },
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-02-23"), Timesheet_ID = 5, Hours_Worked = 4, Recruitment_ID = 16 },
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-02-24"), Timesheet_ID = 6, Hours_Worked = 8, Recruitment_ID = 15 },
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-02-25"), Timesheet_ID = 7, Hours_Worked = 4, Recruitment_ID = 14 },
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-02-26"), Timesheet_ID = 8, Hours_Worked = 4, Recruitment_ID = 13 },
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-02-27"), Timesheet_ID = 9, Hours_Worked = 8, Recruitment_ID = 12 },
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-02-28"), Timesheet_ID = 10, Hours_Worked = 4, Recruitment_ID = 11 },
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-03-01"), Timesheet_ID = 11, Hours_Worked = 4, Recruitment_ID = 10 },
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-03-02"), Timesheet_ID = 12, Hours_Worked = 8, Recruitment_ID = 9 },
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-03-03"), Timesheet_ID = 13, Hours_Worked = 4, Recruitment_ID = 8 },
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-03-04"), Timesheet_ID = 14, Hours_Worked = 4, Recruitment_ID = 7 },
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-03-05"), Timesheet_ID = 15, Hours_Worked = 8, Recruitment_ID = 6 },
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-03-06"), Timesheet_ID = 16, Hours_Worked = 4, Recruitment_ID = 5 },
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-03-07"), Timesheet_ID = 17, Hours_Worked = 4, Recruitment_ID = 4 },
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-03-08"), Timesheet_ID = 18, Hours_Worked = 8, Recruitment_ID = 3 },
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-03-09"), Timesheet_ID = 19, Hours_Worked = 4, Recruitment_ID = 2 },
                new TimesheetModel { Date_Uploaded = DateTime.Parse("2025-03-10"), Timesheet_ID = 20, Hours_Worked = 4, Recruitment_ID = 1 }
            };

            return View(timesheets);
        }
    }
}
