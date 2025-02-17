using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { }

    public DbSet<User> Users { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Recruiter> Recruiters { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<StudentWorker> StudentWorkers { get; set; }
    public DbSet<RightToWorkDocument> RightToWorkDocuments { get; set; }
    public DbSet<VisaStatus> VisaStatuses { get; set; }
    public DbSet<WorkingHoursOffer> WorkingHoursOffers { get; set; }
    public DbSet<Timesheet> Timesheets { get; set; }
}
