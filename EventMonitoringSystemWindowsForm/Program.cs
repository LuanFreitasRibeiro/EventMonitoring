using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using EventMonitoringSystem.Application.Repository;
using EventMonitoringSystem.Application.Usecases.Device;
using EventMonitoringSystem.Infrastructure.Database.Repositories;
using EventMonitoringSystem.Application.Usecases.Event;

namespace EventMonitoringSystemWindowsForm
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();


            services.AddSingleton<IDeviceRepository, DeviceRepository>();
            services.AddSingleton<IDeviceEventRepository, DeviceEventRepository>();

            services.AddTransient<GetAllDevicesUseCase>();
            services.AddTransient<AddDeviceUseCase>();
            services.AddTransient<AckEventUseCase>();
            services.AddTransient<ResolveEventUseCase>();
            services.AddTransient<TriggerEventUseCase>();
            services.AddTransient<MainForm>();
            services.AddDbContext<AppDbContext>();

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                ApplicationConfiguration.Initialize();
                var mainForm = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(mainForm);
            }
        }
    }
}