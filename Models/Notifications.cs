using Microsoft.AspNetCore.Mvc;

namespace Student_Dashboard.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Time { get; set; }
        public bool Read { get; set; }
    }
}
