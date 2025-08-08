namespace EventMonitoringSystem.Domain.Entities.Identity;

public class UUIDGenerator
{
    public static string Create() => Guid.NewGuid().ToString();
}

