namespace CampusJobsProject___Group_34.Models
{
    public class VisaStatusModel
    {
        public int VisaStatusId { get; set; }
        public int StudentId { get; set; }
        public bool Status { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
