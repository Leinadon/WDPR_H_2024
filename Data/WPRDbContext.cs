using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WPR;
using WPR.Models;

public class WPRDbContext : IdentityDbContext<User>
{
    public DbSet<Company> Companies { get; set; }
    public DbSet<Questionnaire> Questionnaires { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<ChatMessage> ChatMessages { get; set; }

    public WPRDbContext(DbContextOptions<WPRDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<DisabilityType>()
            .HasMany(d => d.)

        modelBuilder.Entity<Chat>()
            .HasMany(c => c.Messages)
            .WithOne(cm => cm.Chat)
            .OnDelete(DeleteBehavior.Cascade);
    }
}