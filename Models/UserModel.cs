namespace CampusJobsProject___Group_34.Models
{
    public class UserModel
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; } = string.Empty;
    }

    public class AdminModel : UserModel
    {
        //model for admin database
        public int AdminId { get; set; }
    }

    public class StudentModel : UserModel
    {
        //model for student database
        public int StudentId { get; set; }
        public int VisaStatusId { get; set; }
    }

    public class RecruiterModel : UserModel
    {
        //model for recruiter database
        public int RecruiterId { get; set; }
    }

    public class EmployeeModel : StudentModel
    {
        public int JobId { get; set; }
    }

}
