
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Graph.Models;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Identity.Web;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

using System.Text;
using Microsoft.AspNetCore.Authentication.AzureAD.UI;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;




namespace WPR
{
    public class Startup
    {
        
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection services){
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
            
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = Configuration.GetConnectionString("AZURE_REDIS_CONNECTIONSTRING");
                options.InstanceName = "AZURE_REDIS_CONNECTIONSTRING";
            });

            //Logging.AddAzureWebAppDiagnostics
            services.AddDbContext<WPRDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING"))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors());
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequiredLength = 8;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedAccount = true;
            });
            services.ConfigureApplicationCookie(options => 
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromDays(30);
                options.LoginPath = "/Account/Login"; // Customize login path
                options.AccessDeniedPath = "/Account/AccessDenied"; // Customize access denied path
            });
            services.AddIdentity<IdentityUser, IdentityRole>()
            .AddEntityFrameworkStores<WPRDbContext>()
            .AddDefaultTokenProviders()
            .AddClaimsPrincipalFactory<UserClaimsPrincipalFactory<IdentityUser, IdentityRole>>();

        
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddMicrosoftIdentityWebApi(Configuration.GetSection("AzureAd"));
            services.AddAuthorization();
            services.AddControllers();

            services.AddLogging(builder =>
            {
                builder.AddConsole();
            });
            

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
