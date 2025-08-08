using EventMonitoringSystem.Application.Repository;
using EventMonitoringSystem.Domain.Entities.Event;
using Microsoft.EntityFrameworkCore;

namespace EventMonitoringSystem.Infrastructure.Database.Repositories;

public class DeviceEventRepository : IDeviceEventRepository
{
    private readonly AppDbContext _context;

    public DeviceEventRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AckEvent(string id)
    {
        var deviceEvent = _context.Events.FirstOrDefault(e => e.Id == id);
        if (deviceEvent == null)
            throw new InvalidOperationException($"Event with ID {id} not found.");
        deviceEvent.IsAcknowledged = true;
        await _context.SaveChangesAsync();
    }

    public async Task EvenTrigger(DeviceEvent deviceEvent)
    {
        _context.Events.Add(deviceEvent);
        await _context.SaveChangesAsync();
    }

    public Task<bool> Exists(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<DeviceEvent>> GetAllEvents()
    {
        return await _context.Events.ToListAsync();
    }

    public async Task<DeviceEvent> GetById(string id)
    {
        return _context.Events.FirstOrDefault(e => e.Id == id);
    }

    public async Task<IEnumerable<DeviceEvent>> GetEventsByDeviceId(string deviceId)
    {
        return await _context.Events.Where(e => e.DeviceId == deviceId)
            .ToListAsync();
    }

    public Task ResolveEvent(string id)
    {
        var deviceEvent = _context.Events.FirstOrDefault(e => e.Id == id);
        if (deviceEvent == null)
            throw new InvalidOperationException($"Event with ID {id} not found.");
        deviceEvent.IsResolved = true;
        return _context.SaveChangesAsync();
    }
}

