using EventMonitoringSystem.Application.Repository;

namespace EventMonitoringSystem.Application.Usecases.Event;

public class AckEventUseCase
{
    private readonly IDeviceEventRepository _deviceEventRepository;

    public AckEventUseCase(IDeviceEventRepository deviceEventRepository)
    {
        _deviceEventRepository = deviceEventRepository;
    }

    public async Task Execute(string id)
    {
        if (string.IsNullOrEmpty(id))
        {
            throw new ArgumentException("Event ID cannot be null or empty.", nameof(id));
        }
        var eventToAck = await _deviceEventRepository.GetById(id);
        if (eventToAck == null)
        {
            throw new KeyNotFoundException($"Event with ID {id} not found.");
        }
        if (eventToAck.IsAcknowledged)
        {
            throw new InvalidOperationException($"Event with ID {id} is already acknowledged.");
        }
        await _deviceEventRepository.AckEvent(id);
    }
}

