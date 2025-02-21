using Microsoft.AspNetCore.Mvc;
using CampusJobsProject___Group_34.Models;
using System;
using System.Collections.Generic;

namespace CampusJobsProject___Group_34.Controllers
{
    public class NotificationsController : Controller
    {
        public IActionResult Index()
        {
            var notifications = new List<NotificationModel>
            {
                new NotificationModel { NotificationID = 1, Message = "Your shift for 2025-02-20 has been approved.", Time = DateTime.Parse("2025-02-19 10:00"), Read = false },
                new NotificationModel { NotificationID = 2, Message = "Reminder: Shift ID S001 starts tomorrow.", Time = DateTime.Parse("2025-02-19 08:00"), Read = false },
                new NotificationModel { NotificationID = 3, Message = "Your leave request has been denied.", Time = DateTime.Parse("2025-02-18 14:30"), Read = true },
                new NotificationModel { NotificationID = 4, Message = "Your shift has been updated.", Time = DateTime.Parse("2025-02-18 09:00"), Read = false },
                new NotificationModel { NotificationID = 5, Message = "A new recruiter has been assigned to your shift.", Time = DateTime.Parse("2025-02-17 16:00"), Read = false },
                new NotificationModel { NotificationID = 6, Message = "Your shift start time has been adjusted.", Time = DateTime.Parse("2025-02-16 13:00"), Read = false },
                new NotificationModel { NotificationID = 7, Message = "You have a new message from HR.", Time = DateTime.Parse("2025-02-15 11:00"), Read = true },
                new NotificationModel { NotificationID = 8, Message = "Your request for shift change has been approved.", Time = DateTime.Parse("2025-02-14 10:30"), Read = false },
                new NotificationModel { NotificationID = 9, Message = "Reminder: Your shift starts in 1 hour.", Time = DateTime.Parse("2025-02-20 08:30"), Read = false },
                new NotificationModel { NotificationID = 10, Message = "You’ve been added to a new project team.", Time = DateTime.Parse("2025-02-13 17:15"), Read = true }
            };

            return View(notifications);
        }
    }
}
