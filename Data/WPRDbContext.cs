using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WPR;

public class WPRDbContext : IdentityDbContext<User>
{
    public DbSet<Company> Companies { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<ChatMessage> ChatMessages { get; set; }
    public DbSet<Research> Researches { get; set; }
    public DbSet<Questionnaire> Questionnaires { get; set; }
    public DbSet<Interview> Interviews { get; set; }
    public DbSet<OnlineAssignment> OnlineAssignment { get; set; }

    public WPRDbContext(DbContextOptions<WPRDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Company>().OwnsOne(c => c.Location, l =>
        {
            l.Property(loc => loc.StreetName).IsRequired();
            l.Property(loc => loc.PostalCode).IsRequired();
            l.Property(loc => loc.HouseNumber);
            l.Property(loc => loc.Place).IsRequired();
        });

        modelBuilder.Entity<Specialist>().OwnsOne(c => c.Location, l =>
        {
            l.Property(loc => loc.StreetName).IsRequired();
            l.Property(loc => loc.PostalCode).IsRequired();
            l.Property(loc => loc.HouseNumber);
            l.Property(loc => loc.Place).IsRequired();
        });

        modelBuilder.Entity<Chat>()
            .HasMany(c => c.Messages)
            .WithOne(cm => cm.Chat)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Research>()
            .HasDiscriminator<string>("ResearchType")
            .HasValue<Questionnaire>("Questionnaire")
            .HasValue<Interview>("Interview")
            .HasValue<OnlineAssignment>("OnlineAssignment");
    }
}