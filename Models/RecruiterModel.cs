using System.ComponentModel.DataAnnotations.Schema;

namespace CampusJobsProject___Group_34.Models
{
    public class RecruiterModel
    {
        [Column("Recruitment_ID")]
        public int Recruitment_ID { get; set; }

        [Column("User_ID")]
        public int User_ID { get; set; } 
    }
}
