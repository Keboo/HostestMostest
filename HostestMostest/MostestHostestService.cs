using Microsoft.Extensions.Logging;

namespace HostestMostest;

public class MostestHostestService
{
    public MostestHostestService(ILogger<MostestHostestService> logger)
    {
        Logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public Task ActivateAsync()
    {
        Logger.LogInformation("Activate information");

        Logger.LogWarning("Activation warning! The GenericHost is too awesome!");

        return Task.CompletedTask;
    }

    public ILogger<MostestHostestService> Logger { get; }
}
