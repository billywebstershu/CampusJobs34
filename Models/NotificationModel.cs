namespace CampusJobsProject___Group_34.Models
{
    public class NotificationModel
    {
        public int NotificationID { get; set; }
        public int UserID { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public bool Read { get; set; }
    }
}
