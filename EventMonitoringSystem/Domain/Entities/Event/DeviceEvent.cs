namespace EventMonitoringSystem.Domain.Entities.Event;

public class DeviceEvent
{
    public string Id { get; set; }
    public string DeviceId { get; set; }
    public string Message { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public bool IsAcknowledged { get; set; } = false;
    public bool IsResolved { get; set; } = false;

    //empty constructor for migrations
    public DeviceEvent()
    {
        
    }

    public DeviceEvent(string id, string deviceId, string message, DateTime? timestamp = null, bool isAcknowledged = false, bool isResolved = false)
    {
        Id = id;
        DeviceId = deviceId;
        Message = message;
        Timestamp = timestamp ?? DateTime.Now;
        IsAcknowledged = isAcknowledged;
        IsResolved = isResolved;
    }

    public static DeviceEvent Create(string deviceId, string message)
    {
        var eventId = Guid.NewGuid().ToString();
        return new DeviceEvent(eventId, deviceId, message);
    }

    public static DeviceEvent Restore(string id, string deviceId, string message, DateTime timestamp, bool isAcknowledged = false, bool isResolved = false)
    {
        return new DeviceEvent(id, deviceId, message, timestamp, isAcknowledged, isResolved);
    }
}

