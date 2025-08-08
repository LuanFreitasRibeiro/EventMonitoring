using EventMonitoringSystem.Application.Repository;
using EventMonitoringSystem.Domain.Entities.Device;

namespace EventMonitoringSystem.Application.Usecases.Device;

public class AddDeviceUseCase
{
    private readonly IDeviceRepository _deviceRepository;

    public AddDeviceUseCase(IDeviceRepository deviceRepository)
    {
        _deviceRepository = deviceRepository;
    }

    public async Task Execute(string name, string type)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Device name cannot be null or empty.", nameof(name));
        }
        if (string.IsNullOrEmpty(type))
        {
            throw new ArgumentException("Device type cannot be null or empty.", nameof(type));
        }
        var device = DeviceItem.Create(name, type);
        await _deviceRepository.AddDevice(device);
    }
}
