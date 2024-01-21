using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WPR;

public class WPRDbContext : IdentityDbContext<IdentityUser>
{
    public DbSet<Company> Companies { get; set; }
    public DbSet<OurChat> OurChats { get; set; }
    public DbSet<OurChatMessage> OurChatMessages { get; set; }
    public DbSet<DisabilityType> DisabilityTypes { get; set; }
    public DbSet<Disability> Disabilities { get; set; }
    public DbSet<DoesResearch> DoesResearches { get; set; }
    public DbSet<Guardian> Guardians { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Specialist> Specialists { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<OnlineAssignmentResult> OnlineAssignmentResults { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Research> Researches { get; set; }
    public DbSet<OnlineAssignment> OnlineAssignments { get; set; }

    public DbSet<Roles> Roles { get; set; }


    public DbSet<Answer> Answers { get; set; }

    public WPRDbContext(DbContextOptions<WPRDbContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.EnableDetailedErrors();
            base.OnConfiguring(optionsBuilder);
        }

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("MyCustomSchema");


        base.OnModelCreating(modelBuilder);


    }
}