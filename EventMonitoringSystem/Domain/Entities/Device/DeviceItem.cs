namespace EventMonitoringSystem.Domain.Entities.Device;

public class DeviceItem
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    //empty constructor for migrations
    public DeviceItem()
    {
        
    }

    public DeviceItem(string id, string name, string type, DateTime? createdAt = null, DateTime? updatedAt = null)
    {
        Id = id;
        Name = name;
        Type = type;
        CreatedAt = createdAt ?? DateTime.Now;
        UpdatedAt = updatedAt ?? DateTime.Now;
    }

    public static DeviceItem Create(string name, string type)
    {
        var deviceId = Guid.NewGuid().ToString();
        return new DeviceItem(deviceId, name, type);
    }

    public static DeviceItem Restore(string id, string name, string type, DateTime createdAt, DateTime updatedAt)
    {
        return new DeviceItem(id, name, type, createdAt, updatedAt);
    }
}

