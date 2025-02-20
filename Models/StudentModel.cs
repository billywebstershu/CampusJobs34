using System.ComponentModel.DataAnnotations.Schema;

namespace CampusJobsProject___Group_34.Models
{
    public class StudentModel
    {
        [Column("Student_ID")]
        public int Student_ID { get; set; }  

        [Column("User_ID")]
        public int User_ID { get; set; }  

        [Column("VisaStatus_ID")]
        public int VisaStatus_ID { get; set; }  
    }

    public class EmployeeModel : StudentModel
    {
        [Column("Recruitment_ID")]
        public int Recruitment_ID { get; set; }
    }
}
