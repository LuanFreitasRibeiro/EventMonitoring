using EventMonitoringSystem.Application.Repository;
using EventMonitoringSystem.Domain.Entities.Event;

namespace EventMonitoringSystem.Application.Usecases.Event;

public class TriggerEventUseCase
{
    private readonly IDeviceEventRepository _deviceEventRepository;
    private readonly IDeviceRepository _deviceRepository;

    public TriggerEventUseCase(IDeviceEventRepository deviceEventRepository, IDeviceRepository deviceRepository)
    {
        _deviceEventRepository = deviceEventRepository;
        _deviceRepository = deviceRepository;
    }

    public async Task Execute(DeviceEvent deviceEvent)
    {
        if (deviceEvent == null)
        {
            throw new ArgumentNullException(nameof(deviceEvent), "Device event cannot be null.");
        }
        if (string.IsNullOrEmpty(deviceEvent.DeviceId))
        {
            throw new ArgumentException("Device ID cannot be null or empty.", nameof(deviceEvent.DeviceId));
        }
        var deviceFound = await _deviceRepository.GetById(deviceEvent.DeviceId);
        if (deviceFound == null)
        {
            throw new KeyNotFoundException($"Device with ID {deviceEvent.DeviceId} not found.");
        }
        var createDeviceEvent = DeviceEvent.Create(deviceEvent.DeviceId, deviceEvent.Message);
        await _deviceEventRepository.EvenTrigger(createDeviceEvent);
    }
}

