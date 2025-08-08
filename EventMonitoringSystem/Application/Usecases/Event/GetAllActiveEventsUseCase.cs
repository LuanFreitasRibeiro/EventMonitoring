using EventMonitoringSystem.Application.Repository;
using EventMonitoringSystem.Domain.Entities.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMonitoringSystem.Application.Usecases.Event;

public class GetAllActiveEventsUseCase
{
    private readonly IDeviceEventRepository _deviceEventRepository;
    public GetAllActiveEventsUseCase(IDeviceEventRepository deviceEventRepository)
    {
        _deviceEventRepository = deviceEventRepository;
    }
    public async Task<IEnumerable<DeviceEvent>> Execute()
    {
        var allEvents = await _deviceEventRepository.GetAllEvents();
        return allEvents.Where(e => e.IsResolved == false);
    }
}

