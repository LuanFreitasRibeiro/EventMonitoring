using EventMonitoringSystem.Application.Usecases.Device;
using EventMonitoringSystem.Application.Usecases.Event;
using EventMonitoringSystem.Application.Repository;
using EventMonitoringSystem.Domain.Entities.Event;
using EventMonitoringSystem.Domain.Entities.Device;

namespace EventMonitoringSystemWindowsForm
{
    public partial class MainForm : Form
    {
        private readonly GetAllDevicesUseCase _getAllDevicesUseCase;
        private readonly AddDeviceUseCase _addDeviceUseCase;
        private readonly AckEventUseCase _ackEventUseCase;
        private readonly ResolveEventUseCase _resolveEventUseCase;
        private readonly TriggerEventUseCase _triggerEventUseCase;
        private readonly IDeviceEventRepository _deviceEventRepository;

        public MainForm(
            GetAllDevicesUseCase getAllDevicesUseCase,
            AddDeviceUseCase addDeviceUseCase,
            AckEventUseCase ackEventUseCase,
            ResolveEventUseCase resolveEventUseCase,
            TriggerEventUseCase triggerEventUseCase,
            IDeviceEventRepository deviceEventRepository)
        {
            _getAllDevicesUseCase = getAllDevicesUseCase;
            _addDeviceUseCase = addDeviceUseCase;
            _ackEventUseCase = ackEventUseCase;
            _resolveEventUseCase = resolveEventUseCase;
            _triggerEventUseCase = triggerEventUseCase;
            _deviceEventRepository = deviceEventRepository;
            InitializeComponent();
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await LoadDevicesAsync();
        }

        private async void buttonAddDevice_Click(object sender, EventArgs e)
        {
            var name = textBoxDeviceName.Text.Trim();
            var type = textBoxDeviceType.Text.Trim();
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Please enter both device name and type.");
                return;
            }
            try
            {
                await _addDeviceUseCase.Execute(name, type);
                await LoadDevicesAsync();
                textBoxDeviceName.Clear();
                textBoxDeviceType.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding device: {ex.Message}");
            }
        }

        private class DeviceListBoxItem
        {
            public DeviceItem Device { get; }
            public DeviceListBoxItem(DeviceItem device)
            {
                Device = device;
            }
            public override string ToString()
            {
                return $"{Device.Name} ({Device.Type})";
            }
        }

        private class DeviceEventListBoxItem
        {
            public DeviceEvent DeviceEvent { get; }
            public DeviceEventListBoxItem(DeviceEvent deviceEvent)
            {
                DeviceEvent = deviceEvent;
            }
            public override string ToString()
            {
                return $"{DeviceEvent.Message} - Ack: {DeviceEvent.IsAcknowledged} - Resolved: {DeviceEvent.IsResolved}";
            }
        }

        private async Task LoadDevicesAsync()
        {
            listBoxDevices.Items.Clear();
            try
            {
                var devices = _getAllDevicesUseCase.Execute();
                foreach (var device in devices)
                {
                    listBoxDevices.Items.Add(new DeviceListBoxItem(device));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading devices: {ex.Message}");
            }
        }

        private string GetSelectedDeviceId()
        {
            if (listBoxDevices.SelectedItem is DeviceListBoxItem item)
                return item.Device.Id;
            throw new InvalidOperationException("No device selected.");
        }

        private async void buttonLoadEvents_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Clear();
            var events = await _deviceEventRepository.GetAllEvents();
            foreach (var ev in events)
            {
                listBoxEvents.Items.Add(new DeviceEventListBoxItem(ev));
            }
        }

        private async void buttonAckEvent_Click(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItem == null)
            {
                MessageBox.Show("Select an event to acknowledge.");
                return;
            }
            var eventId = GetSelectedEventId();
            await _ackEventUseCase.Execute(eventId);
            buttonLoadEvents_Click(sender, e);
        }

        private async void buttonResolveEvent_Click(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItem == null)
            {
                MessageBox.Show("Select an event to resolve.");
                return;
            }
            var eventId = GetSelectedEventId();
            await _resolveEventUseCase.Execute(eventId);
            buttonLoadEvents_Click(sender, e);
        }

        private async void buttonTriggerEvent_Click(object sender, EventArgs e)
        {
            if (listBoxDevices.SelectedItem == null)
            {
                MessageBox.Show("Select a device to trigger an event.");
                return;
            }
            var deviceId = GetSelectedDeviceId();
            var message = textBoxEventMessage.Text.Trim();
            var deviceEvent = new DeviceEvent
            {
                DeviceId = deviceId,
                Message = message,
            };
            await _triggerEventUseCase.Execute(deviceEvent);
            buttonLoadEvents_Click(sender, e);
        }


        private string GetSelectedEventId()
        {
            if(listBoxEvents.SelectedItem is DeviceEventListBoxItem item)
                return item.DeviceEvent.Id;
            throw new InvalidOperationException("No event selected");
        }
    }
}
