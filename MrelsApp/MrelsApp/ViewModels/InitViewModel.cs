using System.Windows.Input;
using MrelsApp.Utils;
using MrelsApp.ViewModels.MainViewModels;
using MrelsApp.ViewModels.UserViewModels;
using MrelsApp.Views;
using MrelsApp.Views.UserViews;
using Xamarin.Forms;
using LoginPage = MrelsApp.Views.MainViews.LoginPage;

namespace MrelsApp.ViewModels
{
    public class InitViewModel : BaseViewModel
    {
        #region Properties

        public ICommand LoginCommand => new RelayCommand(this.LoginCommandExecute);

        public ICommand RegisterCommand => new RelayCommand(this.RegisterCommandExecute);

        #endregion

        #region Commands

        private async void LoginCommandExecute()
        {
            MainViewModel.GetInstanceMainViewModel().LoginVm = new LoginViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }

        private async void RegisterCommandExecute()
        {
            MainViewModel.GetInstanceMainViewModel().UserVm = new UserViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new UserPage());
        }

        #endregion
    }
}
