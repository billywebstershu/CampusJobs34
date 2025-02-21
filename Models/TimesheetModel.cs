namespace CampusJobsProject___Group_34.Models
{
    public class TimesheetModel
    {
        public int Timesheet_ID { get; set; }
        public int Student_ID { get; set; }
        public int Recruitment_ID { get; set; }
        public decimal Hours_Worked { get; set; }
        public bool Status { get; set; }
        public DateTime Date_Uploaded { get; set; }
        public DateTime Date_Reviewed { get; set; }
        public string RecruiterFirstName { get; set; }  
        public string RecruiterLastName { get; set; }   
    }
}
