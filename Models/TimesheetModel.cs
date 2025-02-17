namespace CampusJobsProject___Group_34.Models
{
    public class TimesheetModel
    {
        public int TimesheetId { get; set; }
        public int StudentId { get; set;}
        public int RecruiterId { get; set; }
        public double HoursWorked { get; set; }
        public bool ApprovalStatus { get; set; }
        public DateTime DateUploaded { get; set; }
        public DateTime DateReviewed { get; set; }
    }

    public class WorkingHoursModel
    {
        public int OfferId { get; set; }
        public int StudentId { get; set; }
        public int RecruiterId { get; set; }
        public double HoursOffered { get; set; }

        //true if approved by admin, false if rejected or unanswered
        public bool ApprovalStatus { get; set; }

        //true if accepted by student, false if rejected or unanswered
        public bool AcceptedStatus { get; set; }
        public DateTime DateOffered { get; set; }
    }
}
