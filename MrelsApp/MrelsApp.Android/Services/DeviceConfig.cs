using System.Collections.Generic;
using System.Threading.Tasks;
using MrelsApp.DeviceB;

[assembly: Xamarin.Forms.Dependency(typeof(MrelsApp.Droid.Services.DeviceConfig))]
namespace MrelsApp.Droid.Services
{
    public class DeviceConfig : IDeviceConfig
    {

        #region Constructor

        public DeviceConfig()
        {

        }

        #endregion


        public Task Start(string name, int sleepTime, bool readAsCharArray)
        {
            throw new System.NotImplementedException();
        }

        public void Disconnect()
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<BluetoothDeviceModel>> GetDevices()
        {
            var result = new List<BluetoothDeviceModel>();

            return result;
        }
    }
}