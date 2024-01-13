
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Graph.Models;

namespace WPR
{
    public class Startup
    {
        
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection serviceCollection){
            var services = DbContextConfiguration.AddCustomDbContext(serviceCollection, Configuration);
            services.AddScoped<IChatService, ChatService>();
            services.AddScoped<IAnswerService, AnswerService>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IDisabilityService, DisabilityService>();
            services.AddScoped<IDisabilityTypeService, DisabilityTypeService>();
            services.AddScoped<IDoesResearchService, DoesResearchService>();
            services.AddScoped<IGuardianService, GuardianService>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<IOnlineAssignmentResultService, OnlineAssignmentResultService>();
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IResearchService, ResearchService>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IChatService, ChatService>();
            services.AddScoped<IChatRepository, ChatRepository>();
            services.AddScoped<IAnswerRepository, AnswerRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IDisabilityRepository, DisabilityRepository>();
            services.AddScoped<IDisabilityTypeRepository, DisabilityTypeRepository>();
            services.AddScoped<IDoesResearchRepository, DoesResearchRepository>();
            services.AddScoped<IGuardianRepository, GuardianRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<IOnlineAssignmentResultRepository, OnlineAssignmentResultRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IResearchRepository, ResearchRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<WPRDbContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequiredLength = 8;
            });
            serviceCollection.AddAuthorization();
            serviceCollection.AddControllers();
        }
            

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
        
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

