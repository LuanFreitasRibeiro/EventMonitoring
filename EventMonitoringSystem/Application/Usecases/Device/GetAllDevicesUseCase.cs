using EventMonitoringSystem.Application.Repository;
using EventMonitoringSystem.Domain.Entities.Device;

namespace EventMonitoringSystem.Application.Usecases.Device;

public class GetAllDevicesUseCase
{
    private readonly IDeviceRepository _deviceRepository;

    public GetAllDevicesUseCase(IDeviceRepository deviceRepository)
    {
        _deviceRepository = deviceRepository;
    }

    public IEnumerable<DeviceItem> Execute()
    {
        return _deviceRepository.GetAllDevices();
    }
}