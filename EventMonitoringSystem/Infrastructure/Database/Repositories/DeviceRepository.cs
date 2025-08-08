using EventMonitoringSystem.Application.Repository;
using EventMonitoringSystem.Domain.Entities.Device;
using Microsoft.EntityFrameworkCore;

namespace EventMonitoringSystem.Infrastructure.Database.Repositories;

public class DeviceRepository : IDeviceRepository
{
    private readonly AppDbContext _context;

    public DeviceRepository(AppDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task AddDevice(DeviceItem device)
    {
        _context.Devices.Add(device);
        await _context.SaveChangesAsync();
    }

    public List<DeviceItem> GetAllDevices()
    {
        return _context.Devices.ToList();
    }

    public async Task<DeviceItem> GetById(string id)
    {
        return await _context.Devices.FirstOrDefaultAsync(device => device.Id == id);
    }
}

