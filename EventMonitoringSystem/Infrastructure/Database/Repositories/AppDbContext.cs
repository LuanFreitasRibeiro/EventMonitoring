using EventMonitoringSystem.Domain.Entities.Device;
using EventMonitoringSystem.Domain.Entities.Event;
using EventMonitoringSystem.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMonitoringSystem.Infrastructure.Database.Repositories;

public class AppDbContext : DbContext
{
    public DbSet<DeviceItem> Devices { get; set; }
    public DbSet<DeviceEvent> Events { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlite("DataSource=event_monitoring_system.db;Cache=Shared");
        optionsBuilder.UseInMemoryDatabase("EventMonitoringSystem");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        var firstDeviceId = UUIDGenerator.Create();
        var secondDeviceId = UUIDGenerator.Create();
        modelBuilder.Entity<DeviceItem>().ToTable("Devices").HasData(
            DeviceItem.Restore(firstDeviceId, "Temperature Sensor", "Sensor", DateTime.Now.AddDays(-10), DateTime.Now),
            DeviceItem.Restore(secondDeviceId, "Door Lock", "Actuator", DateTime.Now.AddDays(-5), DateTime.Now)
        );
        modelBuilder.Entity<DeviceEvent>().ToTable("Events").HasData(
            DeviceEvent.Restore(UUIDGenerator.Create(), firstDeviceId, "Temperature threshold exceeded", DateTime.Now.AddDays(-2), false, false),
            DeviceEvent.Restore(UUIDGenerator.Create(), secondDeviceId, "Door locked", DateTime.Now.AddDays(-1), true, false)
        );
    }
}

