using EventMonitoringSystem.Application.Repository;
using EventMonitoringSystem.Domain.Entities.Device;

namespace EventMonitoringSystem.Application.Usecases.Device;

public class GetDeviceByIDUseCase
{
    private readonly IDeviceRepository _deviceRepository;
    public GetDeviceByIDUseCase(IDeviceRepository deviceRepository)
    {
        _deviceRepository = deviceRepository;
    }
    public async Task<DeviceItem> Execute(string id)
    {
        var device = await _deviceRepository.GetById(id);
        if (device == null)
        {
            throw new KeyNotFoundException($"Device with ID {id} not found.");
        }
        return device;
    }
}

