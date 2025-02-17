namespace CampusJobsProject___Group_34.Models
{
    public class Notification
    {
        public int Notification_ID { get; set; }
        public int User_ID { get; set; }
        public string Message { get; set; }
        public string Time { get; set; }
        public int Read { get; set; }
        public User User { get; set; }
    }
}
