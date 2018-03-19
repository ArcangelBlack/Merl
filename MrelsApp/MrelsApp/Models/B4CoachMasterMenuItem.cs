using System;
using System.Windows.Input;
using MrelsApp.Services;
using MrelsApp.Utils;

namespace MrelsApp.Models
{
    public class B4CoachMasterMenuItem
    {
        #region Constructor

        private NavigationService navigationService;

        #endregion

        #region Properties

        public B4CoachMasterMenuItem()
        {
            this.navigationService = new NavigationService();
        }

        #endregion

        #region Properties

        public int Id { get; set; }

        public string Icon { get; set; }

        public string Title { get; set; }

        public string TargetType { get; set; }

        public ICommand NavigationCommand => new RelayCommand(this.NavigationCommandExecute);

        #endregion

        #region Commands

        private async void NavigationCommandExecute()
        {
            await this.navigationService.Navigate(TargetType.ToString());
        }

        #endregion
    }
}