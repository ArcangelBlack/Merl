using System.Collections.Generic;
using Android.Bluetooth;
using Android.Bluetooth.LE;

namespace MrelsApp.Droid.Services
{
    public class AndroidScanCallback : ScanCallback
    {
        private readonly Dictionary<string, BluetoothDevice> _bluetoothDevices;

        public AndroidScanCallback(Dictionary<string, BluetoothDevice> devices)
        {
            _bluetoothDevices = devices;
        }

        public override void OnScanResult(ScanCallbackType callbackType, ScanResult result)
        {
            base.OnScanResult(callbackType, result);
            _bluetoothDevices[result.Device.Address] = result.Device;
        }
    }
}