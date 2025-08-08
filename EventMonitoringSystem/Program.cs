using EventMonitoringSystem.Application.Repository;
using EventMonitoringSystem.Application.Usecases.Device;
using EventMonitoringSystem.Application.Usecases.Event;
using EventMonitoringSystem.Infrastructure.Database.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EventMonitoringSystem;

class Program
{
    static void Main()
    {
        var services = new ServiceCollection();
        services.AddSingleton<IDeviceRepository, DeviceRepository>();
        services.AddSingleton<IDeviceEventRepository, DeviceEventRepository>();
        services.AddSingleton<AddDeviceUseCase>();
        services.AddSingleton<GetAllDevicesUseCase>();
        services.AddSingleton<GetDeviceByIDUseCase>();
        services.AddSingleton<AckEventUseCase>();
        services.AddSingleton<GetAllActiveEventsUseCase>();
        services.AddSingleton<ResolveEventUseCase>();
        services.AddSingleton<TriggerEventUseCase>();
        services.AddDbContext<AppDbContext>();
        var serviceProvider = services.BuildServiceProvider();
    }
}
