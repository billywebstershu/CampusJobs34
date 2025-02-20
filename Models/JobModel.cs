namespace CampusJobsProject___Group_34.Models
{
    public class JobModel
    {
        public int JobId { get; set; }
        public int RecruiterId { get; set; }
        public string Title { get; set; }
        public string PostNumber { get; set; }
        public decimal PayRate { get; set; }
        public string CostCode { get; set; }
        public int MaxAvailableHours { get; set; }
    }
}
