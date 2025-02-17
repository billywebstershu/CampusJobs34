namespace CampusJobsProject___Group_34.Models
{
    public class RightToWorkDocument
    {
        public int RTW_ID { get; set; }
        public int Student_ID { get; set; }
        public string Document_URL { get; set; }
        public string Upload_Date { get; set; }
        public Employee Employee { get; set; }
    }
}
