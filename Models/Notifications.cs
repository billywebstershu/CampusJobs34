using Microsoft.AspNetCore.Mvc;

namespace CampusJobsProject___Group_34.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Time { get; set; }
        public bool Read { get; set; }
    }
}
