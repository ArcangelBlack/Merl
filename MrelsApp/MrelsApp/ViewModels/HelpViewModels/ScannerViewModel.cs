using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using MrelsApp.DeviceB;
using MrelsApp.Utils;

namespace MrelsApp.ViewModels.HelpViewModels
{
    public class ScannerViewModel : BaseViewModel
    {
        #region Fields

        private ObservableCollection<BluetoothDeviceModel> items;

        #endregion

        #region Constructor

        public ScannerViewModel()
        {
            this.Items = new ObservableCollection<BluetoothDeviceModel>();
        }

        #endregion

        #region Properties

        public ObservableCollection<BluetoothDeviceModel> Items
        {
            get => items;
            set => this.SetProperty(ref this.items, value);
        }

        public ICommand ScannerDevices => new RelayCommand(this.ScannerDevicesExecute);

        #endregion

        private void ScannerDevicesExecute()
        {
            this.ExecuteLoadItemsCommand();
        }

        public async void ExecuteLoadItemsCommand()
        {
            if (this.IsBusy)
                return;

            this.IsBusy = true;

            try
            {


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                this.IsBusy = false;
            }
        }
    }
}
