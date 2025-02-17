namespace CampusJobsProject___Group_34.Models
{
    public class Timesheet
    {
        public int Timesheet_ID { get; set; }
        public int Student_ID { get; set; }
        public int Recruitment_ID { get; set; }
        public double Hours_Worked { get; set; }
        public int Status { get; set; }
        public string Date_Uploaded { get; set; }
        public string Date_Reviewed { get; set; }
        public Employee Employee { get; set; }
        public Recruiter Recruiter { get; set; }
    }
}
