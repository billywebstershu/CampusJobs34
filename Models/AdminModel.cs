using System.ComponentModel.DataAnnotations.Schema;

namespace CampusJobsProject___Group_34.Models
{
    public class AdminModel
    {
        [Column("Admin_ID")]
        public int Admin_ID { get; set; }

        [Column("User_ID")]
        public int User_ID { get; set; }  
    }
}
