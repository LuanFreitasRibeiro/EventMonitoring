using EventMonitoringSystem.Domain.Entities.Event;

namespace EventMonitoringSystem.Application.Repository;

public interface IDeviceEventRepository
{
    Task EvenTrigger(DeviceEvent deviceEvent);
    Task<DeviceEvent> GetById(string id);
    Task<IEnumerable<DeviceEvent>> GetAllEvents();
    Task AckEvent(string id);
    Task ResolveEvent(string id);
    Task<bool> Exists(string id);
    Task<IEnumerable<DeviceEvent>> GetEventsByDeviceId(string deviceId);
}

