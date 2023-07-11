namespace HostestMostest;

/// <summary>
/// Requirements:
/// Must be non-abstract with a public parameterless constructor
/// Contain public read-write properties to bind(fields are not bound)
/// Source: https://learn.microsoft.com/dotnet/core/extensions/options#bind-hierarchical-configuration
/// </summary>
public class Hostest
{
    public const string SectionName = "Hostest";

    public bool MostestModeEnabled { get; set; }
}