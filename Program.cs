using App.Metrics;
using App.Metrics.AspNetCore;

namespace WPR{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Succesvol gestart");
            CreateHostBuilder(args).Build().Run();
            Console.WriteLine("Succesvol afgesloten");

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args).UseMetricsWebTracking()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // IMetrics = AppMetrics.CreateDefaultBuilder()
                    //     .OutputMetrics.AsPrometheusPlainText()
                    //     .OutputMetrics.AsPrometheusProtobuf()
                    //     .Build();
                    webBuilder.UseStartup<Startup>();
                }
        );
    }
}
