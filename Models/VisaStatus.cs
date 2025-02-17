namespace CampusJobsProject___Group_34.Models
{
    public class VisaStatus
    {
        public int VisaStatusID { get; set; }
        public int Student_ID { get; set; }
        public int Status { get; set; }
        public int ExpiryDate { get; set; }
        public Employee Employee { get; set; }
    }
}
