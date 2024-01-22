using App.Metrics;
using App.Metrics.AspNetCore;
using App.Metrics.Formatters.Prometheus;

namespace WPR{
    public class Program
    {
        public static IMetricsRoot Metrics {get; set;}
        public static void Main(string[] args)
        {
            Console.WriteLine("Succesvol gestart");
            BuildHost(args).Run();
            Console.WriteLine("Succesvol afgesloten");

        }

        public static IHost BuildHost(string[] args)
        {
            Metrics = AppMetrics.CreateDefaultBuilder()
                    .OutputMetrics.AsPrometheusPlainText()
                    .OutputMetrics.AsPrometheusProtobuf()
                    .Build();

            return Host.CreateDefaultBuilder(args)
                            .ConfigureMetrics(Metrics)
                            .UseMetrics(
                                options =>
                                {
                                    options.EndpointOptions = endpointsOptions =>
                                    {
                                        endpointsOptions.MetricsTextEndpointOutputFormatter = Metrics.OutputMetricsFormatters.OfType<MetricsPrometheusTextOutputFormatter>().First();
                                        endpointsOptions.MetricsEndpointOutputFormatter = Metrics.OutputMetricsFormatters.OfType<MetricsPrometheusProtobufOutputFormatter>().First();
                                    };
                                })
                            .ConfigureWebHostDefaults(webBuilder =>
                            {
                                webBuilder.UseStartup<Startup>();
                            })
                            .Build();
        }
    }
}
