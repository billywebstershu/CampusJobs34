namespace CampusJobsProject___Group_34.Models
{
    public class UserModel
    {
        public int User_ID { get; set; }  
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role { get; set; } 
        public string First_Name { get; set; }  
        public string Last_Name { get; set; } 
        public string Address { get; set; } = string.Empty;
    }

    public class AdminModel : UserModel
    {
        public int Admin_ID { get; set; } 
    }

    public class StudentModel : UserModel
    {
        public int Student_ID { get; set; } 
        public int VisaStatus_ID { get; set; }  
    }

    public class RecruiterModel : UserModel
    {
        public int Recruitment_ID { get; set; }  
    }

    public class EmployeeModel : StudentModel
    {
        public int JobId { get; set; }
    }
}
