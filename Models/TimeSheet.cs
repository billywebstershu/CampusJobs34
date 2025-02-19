namespace Student_Dashboard.Models
{
    public class TimeSheet
    {
        public bool IsVisaRestricted { get; set; }
        public DateTime Date { get; set; }
        public string ShiftId { get; set; }
        public string AvailableShifts { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double TotalHours { get; set; }
        public string Recruiter { get; set; }
    }
}