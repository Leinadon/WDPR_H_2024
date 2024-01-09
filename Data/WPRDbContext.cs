using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WPR;

public class WPRDbContext : DbContext
{
    public DbSet<Company> Companies { get; set; }
    public DbSet<Questionnaire> Questionnaires { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<ChatMessage> ChatMessages { get; set; }
    public DbSet<DisabilityType> DisabilityTypes {get; set; }
    public DbSet<Disability> Disabilities{get; set;}
    public DbSet<Admin> Admins{get;set;}
    public DbSet<Employee> Employees{get;set;}
    public DbSet<Specialist> Specialists{get;set;}
    public DbSet<DoesResearch> DoesResearches{get; set;}
    public DbSet<Guardian> Guardians{get; set;}
    public DbSet<Interview> Interviews{get; set;}
    public DbSet<Location> Locations{get; set;}
    public DbSet<OnlineAssignment> OnlineAssignments{get; set;}
    public DbSet<OnlineAssignmentResult> OnlineAssignmentResults{get;set;}
    public DbSet<Question> Questions{get;set;}
    public DbSet<Research> Researches{get; set;}
    public DbSet<Answer> Answers{get; set;}
    public static void Main()
    {
        
    }
    
    public WPRDbContext(DbContextOptions<WPRDbContext> options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=mydatabase.db");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
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
        //Question relatie naar Answer
        modelBuilder.Entity<Question>()
            .HasMany(a => a.Answers)
            .WithOne(q => q.Question)
            .OnDelete(DeleteBehavior.Cascade);
        //DoesResearch relatie naar Answer
        modelBuilder.Entity<DoesResearch>()
            .HasMany(a => a.Answers)
            .WithOne(dr => dr.DoesResearch)
            .OnDelete(DeleteBehavior.Cascade);
        //Specialist relatie naar Disability
        modelBuilder.Entity<Specialist>()
            .HasMany(sp => sp.Disabilities)
            .WithOne(d => d.Specialist)
            .OnDelete(DeleteBehavior.SetNull);
        //chat relatie naar User
        //deze 2 keer omdat een chat altijd uit 2 users bestaat.
        modelBuilder.Entity<User>()
            .HasMany(c => c.chats)
            .WithOne(u => u.user1)
            .OnDelete(DeleteBehavior.SetNull);
        modelBuilder.Entity<User>()
            .HasMany(c => c.chats)
            .WithOne(u => u.user2)
            .OnDelete(DeleteBehavior.SetNull);
        //user relatie naar bericht
        modelBuilder.Entity<User>()
            .HasMany(u => u.chatMessages)
            .WithOne(c => c.Sender)
            .OnDelete(DeleteBehavior.SetNull);
        //specialist naar doetOnderzoek
        modelBuilder.Entity<Specialist>()
            .HasMany(s => s.doesResearches)
            .WithOne(dr => dr.Specialist)
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
            .WithOne(dr => dr.Research)
            .OnDelete(DeleteBehavior.Cascade);
        //Onderzoek naar DoetOnderzoek
        modelBuilder.Entity<Research>()
            .HasMany(r => r.doesResearches)
            .WithOne(dr => dr.Research)
            .OnDelete(DeleteBehavior.Cascade);
        //doetonderzoek naar Chat
        modelBuilder.Entity<DoesResearch>()
            .HasOne(r => r.Chat)
            .WithOne(c => c.doesResearch)
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
        modelBuilder.Entity<Chat>()
            .HasMany(c => c.Messages)
            .WithOne(m => m.Chat)
            .OnDelete(DeleteBehavior.Cascade);
    }
}