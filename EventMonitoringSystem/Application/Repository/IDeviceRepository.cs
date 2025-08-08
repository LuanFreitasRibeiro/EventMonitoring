using EventMonitoringSystem.Domain.Entities.Device;

namespace EventMonitoringSystem.Application.Repository;

public interface IDeviceRepository
{
    Task AddDevice(DeviceItem device);
    Task<DeviceItem> GetById(string id);
    List<DeviceItem> GetAllDevices();
}

