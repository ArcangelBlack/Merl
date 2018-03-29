using MrelsApp.Converters;

namespace MrelsApp.DeviceB
{
    public class BluetoothDeviceModel
    {
        public string Name { get; set; }

        public string BluetoothAddress { get; set; }

        public BluetoothConnectionStatus ConnectionStatus { get; set; }
    }
}
