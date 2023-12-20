using Microsoft.EntityFrameworkCore;
using WPR.Models;

namespace WPR.Data
{
    public class WPRDbContext : DbContext
    {
        public WPRDbContext(DbContextOptions<WPRDbContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Questionnaire> Questionnaires {get; set; } 
        public DbSet<Chat> Chats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use SQLite database
            optionsBuilder.UseSqlite("Data Source=WPRDatabase.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().ToTable("Companies");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Questionnaire>().ToTable("Questionnaires");

            modelBuilder.Entity<Chat>().ToTable("Chats")
                .HasMany(c => c.Messages)
                .WithOne(cm => cm.Chat)
                .HasForeignKey(m => m.ChatId);

            modelBuilder.Entity<ChatMessage>().ToTable("ChatMessages")
                .HasOne(cm => cm.Chat)
                .WithMany(c => c.Messages)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
