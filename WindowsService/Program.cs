using WindowsService;

IHost host = Host.CreateDefaultBuilder(args)
    .UseWindowsService() //<-- Add this line
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
