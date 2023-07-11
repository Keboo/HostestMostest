// See https://aka.ms/new-console-template for more information
using HostestMostest;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

IHostBuilder hostBuilder = new HostBuilder();

//Setup app configuration
hostBuilder.ConfigureAppConfiguration(configBuilder =>
{
    configBuilder.AddJsonFile("appsettings.json", optional: false);
    configBuilder.AddEnvironmentVariables("MOSTEST__");
    configBuilder.AddCommandLine(args);
});

//Setup DI
hostBuilder.ConfigureServices(serviceCollection =>
{
    serviceCollection.AddSingleton<MostestHostestService>();
});

//Setup logging
hostBuilder.ConfigureLogging((hostingContext, loggingBuilder) =>
{
    loggingBuilder.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));

    loggingBuilder.AddSimpleConsole(options => options.SingleLine = true);
    loggingBuilder.AddDebug();

    //loggingBuilder.AddSystemdConsole();
});



using IHost host = hostBuilder.Build();

var logger = host.Services.GetRequiredService<ILogger<Program>>();
logger.LogInformation("Starting app...");
await host.StartAsync();

var service = host.Services.GetRequiredService<MostestHostestService>();
await service.ActivateAsync();

logger.LogInformation("Running app...");
await host.StopAsync();

logger.LogInformation("Waiting for shutdown...");
await host.WaitForShutdownAsync();

logger.LogInformation("Shutdown...");