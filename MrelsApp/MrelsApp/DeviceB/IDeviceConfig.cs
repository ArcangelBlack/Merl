using System.Collections.Generic;
using System.Threading.Tasks;

namespace MrelsApp.DeviceB
{
    public interface IDeviceConfig
    {
        Task Start(string name, int sleepTime, bool readAsCharArray);

        void Disconnect();

        Task<List<BluetoothDeviceModel>> GetDevices();
    }
}
