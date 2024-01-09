using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WPR;

public class WPRDbContext : IdentityDbContext<User>
{
    public DbSet<Company> Companies { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<ChatMessage> ChatMessages { get; set; }

    public WPRDbContext(DbContextOptions<WPRDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        //DisabilityType relatie naar Disability
        modelBuilder.Entity<DisabilityType>()
            .HasMany(dt => dt.disabilities)
            .WithOne(d => d.DisabilityType)
            .OnDelete(DeleteBehavior.Restrict);
        //Chat relatie naar messages
        modelBuilder.Entity<Chat>()
            .HasMany(c => c.Messages)
            .WithOne(cm => cm.Chat)
            .OnDelete(DeleteBehavior.Cascade);
    }
}