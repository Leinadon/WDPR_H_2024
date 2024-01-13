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
    public DbSet<DisabilityType> DisabilityTypes {get; set; }
    public DbSet<Disability> Disabilities{get; set;}
    public DbSet<DoesResearch> DoesResearches{get; set;}
    public DbSet<Guardian> Guardians{get; set;}
    public DbSet<OurUser> OurUsers{get; set;}
    public DbSet<Location> Locations{get; set;}
    public DbSet<OnlineAssignmentResult> OnlineAssignmentResults{get;set;}
    public DbSet<Question> Questions{get;set;}
    public DbSet<Research> Researches{get; set;}
    public DbSet<Answer> Answers{get; set;}
    
    public WPRDbContext(DbContextOptions<WPRDbContext> options) : base(options) {
        
    }
    public class BloggingContextFactory : IDesignTimeDbContextFactory<WPRDbContext>
    {
        public WPRDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WPRDbContext>();
            optionsBuilder.UseSqlite("Data Source=blog.db");
            

            return new WPRDbContext(optionsBuilder.Options);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /**
         //DisabilityType relatie naar Disability
        modelBuilder.Entity<DisabilityType>()
            .HasMany(dt => dt.disabilities)
            .WithOne(d => d.DisabilityType)
            .OnDelete(DeleteBehavior.Restrict);
        //Chat relatie naar messages
        modelBuilder.Entity<OurChat>()
            .HasMany(c => c.Messages)
            .WithOne(cm => cm.ourChat)
            .OnDelete(DeleteBehavior.Cascade);
        //Question relatie naar Answer
        modelBuilder.Entity<Question>()
            .HasMany(a => a.Answers)
            .WithOne(q => q.Question)
            .OnDelete(DeleteBehavior.Cascade);
        //DoesResearch relatie naar Answer
        modelBuilder.Entity<DoesResearch>()
            .HasMany(dr => dr.Answers)
            .WithOne(a => a.DoesResearch)
            .OnDelete(DeleteBehavior.Cascade);
        //Specialist relatie naar Disability
        modelBuilder.Entity<Specialist>()
            .HasMany(sp => sp.Disabilities)
            .WithOne(d => d.Specialist)
            .OnDelete(DeleteBehavior.SetNull);
        //chat relatie naar User
        //deze 2 keer omdat een chat altijd uit 2 users bestaat.
        modelBuilder.Entity<OurUser>()
            .HasMany(u => u.Chats)
            .WithOne(c => c.User1)
            .HasForeignKey(c => c.User1ID)
            .OnDelete(DeleteBehavior.SetNull);
        modelBuilder.Entity<OurUser>()
            .HasMany(c => c.Chats2)
            .WithOne(u => u.User2)
            .HasForeignKey(c => c.User2ID)
            .OnDelete(DeleteBehavior.SetNull);
        //user relatie naar bericht
        modelBuilder.Entity<OurUser>()
            .HasMany(u => u.ChatMessages)
            .WithOne(c => c.Sender)
            .OnDelete(DeleteBehavior.SetNull);
        //specialist naar doetOnderzoek
        modelBuilder.Entity<Specialist>()
            .HasMany(s => s.doesResearches)
            .WithOne(dr => dr.specialist)
            .OnDelete(DeleteBehavior.SetNull);
        //bedrijf naar bedrijfsaccount
        modelBuilder.Entity<Company>()
            .HasMany(c => c.Employees)
            .WithOne(e => e.Company)
            .OnDelete(DeleteBehavior.SetNull);
        //bedrijf naar onderzoek
        modelBuilder.Entity<Company>()
            .HasMany(c => c.Researches)
            .WithOne(r => r.Company)
            .OnDelete(DeleteBehavior.SetNull);
        //voogd naar ervaringsdeskundige
        modelBuilder.Entity<Specialist>()
            .HasOne(s => s.Guardian)
            .WithOne(g => g.specialist)
            .OnDelete(DeleteBehavior.SetNull);
        //DoetOnderzoek naar Antwoord
        modelBuilder.Entity<DoesResearch>()
            .HasMany(dr => dr.Answers)
            .WithOne(a => a.DoesResearch)
            .OnDelete(DeleteBehavior.Cascade);
        //Onderzoek naar DoetOnderzoek
        modelBuilder.Entity<Research>()
            .HasMany(r => r.doesResearches)
            .WithOne(dr => dr.research)
            .OnDelete(DeleteBehavior.Cascade);
        //doetonderzoek naar Chat
        modelBuilder.Entity<DoesResearch>()
            .HasOne(r => r.chat)
            .WithOne(c => c.DoesResearch)
            .OnDelete(DeleteBehavior.Cascade);
        //interview naar vraag
        modelBuilder.Entity<Interview>()
            .HasMany(i => i.Questions)
            .WithOne(q => q.Interview)
            .OnDelete(DeleteBehavior.Cascade);
        //vragenlijst naar vraag
        modelBuilder.Entity<Questionnaire>()
            .HasMany(q => q.Questions)
            .WithOne(qu => qu.Questionnaire)
            .OnDelete(DeleteBehavior.Cascade);
        //onlineopdracht naar onlineopdracht resultaat
        modelBuilder.Entity<OnlineAssignment>()
            .HasMany(oa => oa.OnlineAssignmentResults)
            .WithOne(oar => oar.OnlineAssignment)
            .OnDelete(DeleteBehavior.Cascade);
        //chat naar bericht
        modelBuilder.Entity<OurChat>()
            .HasMany(c => c.Messages)
            .WithOne(m => m.ourChat)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Specialist>()
            .HasOne(s => s.Location)
            .WithOne(l => l.specialist)
            .OnDelete(DeleteBehavior.SetNull);
        **/
        base.OnModelCreating(modelBuilder);
        
    }
}