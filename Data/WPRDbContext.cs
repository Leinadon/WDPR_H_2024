using Microsoft.EntityFrameworkCore;
using WPR.Models;

namespace WPR.Data
{
    public class WPRDbContext : DbContext
    {
        public WPRDbContext(DbContextOptions<WPRDbContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Questionnaire> Questionnaires {get;set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().ToTable("Companies");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Questionnaire>().ToTable("Questionnaires");
        }
    }
}
