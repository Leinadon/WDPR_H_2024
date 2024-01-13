using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Graph;
using Microsoft.Graph.Authentication;
using Microsoft.Graph.Models.ExternalConnectors;
using Microsoft.Identity.Web;
using Microsoft.Identity.Client;
using WPR;
using Azure.Identity;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Var_P;
using System.ComponentModel;
namespace WPR{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            
            Console.WriteLine("Succesvol gestart");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    
                    webBuilder.UseStartup<Startup>();
                }

                
        );
        
    }
    
}
