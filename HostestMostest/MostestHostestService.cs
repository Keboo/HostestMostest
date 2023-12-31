﻿using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace HostestMostest;

public class MostestHostestService : BackgroundService
{
    public MostestHostestService(
        IOptions<Hostest> options,
        ILogger<MostestHostestService> logger)
    {
        Options = options ?? throw new ArgumentNullException(nameof(options));
        Logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public Task ActivateAsync()
    {
        Logger.LogInformation("Activate information");

        if (Options.Value.MostestModeEnabled)
        {
            Logger.LogCritical("MOSTEST MODE ACTIVATED!");
        }

        Logger.LogWarning("Activation warning! The GenericHost is too awesome!");

        return Task.CompletedTask;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await ActivateAsync();
    }

    public IOptions<Hostest> Options { get; }
    public ILogger<MostestHostestService> Logger { get; }
}
