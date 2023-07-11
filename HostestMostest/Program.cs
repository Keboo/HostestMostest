// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Hosting;

IHostBuilder hostBuilder = new HostBuilder();
using IHost host = hostBuilder.Build();

Console.WriteLine("Starting app...");
await host.StartAsync();

Console.WriteLine("Running app...");
await host.StopAsync();

Console.WriteLine("Waiting for shutdown...");
await host.WaitForShutdownAsync();

Console.WriteLine("Shutdown...");