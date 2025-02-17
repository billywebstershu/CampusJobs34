namespace CampusJobsProject___Group_34.Models
{
    public class WorkingHoursOffer
    {
        public int Offer_ID { get; set; }
        public int Student_ID { get; set; }
        public double Hours_Offered { get; set; }
        public int Status { get; set; }
        public string Offer_Date { get; set; }
        public Employee Employee { get; set; }
    }
}
