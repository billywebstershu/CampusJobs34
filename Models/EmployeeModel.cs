using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampusJobsProject___Group_34.Models
{
    [Table("Employee")]
    public class EmployeeModel
    {
        [Key]
        [Column("Student_ID")]
        public int Student_ID { get; set; }

        [ForeignKey("Recruiter")]
        [Column("Recruitment_ID")]
        public int Recruitment_ID { get; set; }
    }
}

