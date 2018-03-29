using System;
using System.Collections.Generic;
using System.Text;
using MbientLab.MetaWear;

namespace MrelsApp.DeviceB
{
    public class ScanConfig
    {
        internal int Duration { get; }
        internal Type NextPageType { get; }
        public List<Guid> ServiceUuids { get; }

        public ScanConfig(Type nextPageType, int duration = 10000, List<Guid> serviceUuids = null)
        {
            Duration = duration;
            NextPageType = nextPageType;
            ServiceUuids = serviceUuids == null ? new List<Guid>(new Guid[] { Constants.METAWEAR_GATT_SERVICE }) : serviceUuids;
        }
    }
}
