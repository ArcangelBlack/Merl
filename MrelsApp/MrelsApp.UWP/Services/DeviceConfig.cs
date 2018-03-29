using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth.Advertisement;
using MrelsApp.DeviceB;

[assembly: Xamarin.Forms.Dependency(typeof(MrelsApp.UWP.Services.DeviceConfig))]
namespace MrelsApp.UWP.Services
{
    public class DeviceConfig : IDeviceConfig
    {
        private BluetoothLEAdvertisementWatcher btleWatcher;

        private ScanConfig config;

        //public List<BluetoothDeviceModel> GetDevices()
        //{
        //    var result = new List<BluetoothDeviceModel>();
        //    var seenDevices = new HashSet<ulong>();

        //    btleWatcher = new BluetoothLEAdvertisementWatcher
        //    {
        //        ScanningMode = BluetoothLEScanningMode.Active
        //    };
        //    btleWatcher.Received += async (w, btAdv) =>
        //    {
        //        if (!seenDevices.Contains(btAdv.BluetoothAddress) &&
        //            config.ServiceUuids.Aggregate(true, (acc, e) => acc & btAdv.Advertisement.ServiceUuids.Contains(e)))
        //        {
        //            seenDevices.Add(btAdv.BluetoothAddress);
        //            var device = await BluetoothLEDevice.FromBluetoothAddressAsync(btAdv.BluetoothAddress);
        //            if (device != null)
        //            {
        //                var item = new BluetoothDeviceModel
        //                {
        //                    Name = device.Name,
        //                    BluetoothAddress = device.BluetoothAddress,
        //                    ConnectionStatus = (BluetoothConnectionStatus)device.ConnectionStatus
        //                };
        //                result.Add(item);
        //            }
        //        }
        //    };

        //    return result;
        //}

        public Task Start(string name, int sleepTime, bool readAsCharArray)
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public Task<List<BluetoothDeviceModel>> GetDevices()
        {
            throw new NotImplementedException();
        }
    }
}
