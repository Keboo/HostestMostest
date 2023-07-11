// See https://aka.ms/new-console-template for more information
using HostestMostest;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args);

//Setup DI
hostBuilder.ConfigureServices(serviceCollection =>
{
    serviceCollection.AddHostedService<MostestHostestService>();
    serviceCollection.AddOptions<Hostest>()
        .BindConfiguration(Hostest.SectionName);
});

await hostBuilder.RunConsoleAsync();