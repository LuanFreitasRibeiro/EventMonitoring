using EventMonitoringSystem.Application.Repository;

namespace EventMonitoringSystem.Application.Usecases.Event;

public class ResolveEventUseCase
{
    private readonly IDeviceEventRepository _deviceEventRepository;
    public ResolveEventUseCase(IDeviceEventRepository deviceEventRepository)
    {
        _deviceEventRepository = deviceEventRepository;
    }
    public async Task Execute(string id)
    {
        if (string.IsNullOrEmpty(id))
        {
            throw new ArgumentException("Event ID cannot be null or empty.", nameof(id));
        }
        var eventToResolve = await _deviceEventRepository.GetById(id);
        if (eventToResolve == null)
        {
            throw new KeyNotFoundException($"Event with ID {id} not found.");
        }
        if (eventToResolve.IsResolved)
        {
            throw new InvalidOperationException($"Event with ID {id} is already resolved.");
        }
        await _deviceEventRepository.ResolveEvent(id);
    }
}

