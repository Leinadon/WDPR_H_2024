using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Identity.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

namespace WPR
{
    public class Startup
    {

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection services)
        {
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


            services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
                .AddMicrosoftIdentityWebApi(Configuration.GetSection("AzureAd"));
            services.AddAuthorization();
            services.AddControllers();
            services.AddRazorPages();
            services.AddLogging(builder =>
            {
                builder.AddConsole();
            });

            services.AddSwaggerGen();
            services.AddCors(options =>
                   {
                       options.AddPolicy("AllowLocalhost",
                           builder => builder.WithOrigins("http://localhost:3000") // Replace with your React app's URL
                                             .AllowAnyMethod()
                                             .AllowAnyHeader()
                                             .AllowCredentials());
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

            //app.UsePathBase("https://wdp2.azurewebsites.net/");
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            // app.UseCors("AllowLocalhost");

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseCors("AllowLocalhost");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
