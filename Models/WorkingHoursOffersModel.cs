namespace CampusJobsProject___Group_34.Models
{
    public class WorkingHoursOffersModel
    {
        public int Offer_ID { get; set; }
        public int Student_ID { get; set; }
        public decimal Hours_Offered { get; set; }
        public bool Status { get; set; }
        public DateTime Offer_Date { get; set; }
    }
}
