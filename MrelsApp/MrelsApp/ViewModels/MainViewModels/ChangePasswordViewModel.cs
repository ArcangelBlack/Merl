using System.Windows.Input;
using MrelsApp.Services;
using MrelsApp.Utils;

namespace MrelsApp.ViewModels.MainViewModels
{
    public class ChangePasswordViewModel : BaseViewModel
    {
        #region Services
        private ApiService apiService;
        //private DataService dataService;
        #endregion

        #region Properties
        public string CurrentPassword { get; set; }

        public string NewPassword
        {
            get;
            set;
        }

        public string Confirm
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public ChangePasswordViewModel()
        {
            this.apiService = new ApiService();
            //this.dataService = new DataService();
            //this.IsEnabled = true;
        }
        #endregion

        #region Commands
        public ICommand ChangePasswordCommand => new RelayCommand(ChangePassword);

        private async void ChangePassword()
        {
            //if (string.IsNullOrEmpty(this.CurrentPassword))
            //{
            //    await Application.Current.MainPage.DisplayAlert(
            //        Languages.Error,
            //        Languages.PasswordValidation,
            //        Languages.Accept);
            //    return;
            //}

            //if (this.CurrentPassword.Length < 6)
            //{
            //    await Application.Current.MainPage.DisplayAlert(
            //        Languages.Error,
            //        Languages.PasswordValidation2,
            //        Languages.Accept);
            //    return;
            //}

            //if (this.CurrentPassword != MainViewModel.GetInstance().User.Password)
            //{
            //    await Application.Current.MainPage.DisplayAlert(
            //        Languages.Error,
            //        Languages.IncorrectPassword,
            //        Languages.Accept);
            //    return;
            //}

            //if (string.IsNullOrEmpty(this.NewPassword))
            //{
            //    await Application.Current.MainPage.DisplayAlert(
            //        Languages.Error,
            //        Languages.PasswordValidation,
            //        Languages.Accept);
            //    return;
            //}

            //if (this.NewPassword.Length < 6)
            //{
            //    await Application.Current.MainPage.DisplayAlert(
            //        Languages.Error,
            //        Languages.PasswordValidation2,
            //        Languages.Accept);
            //    return;
            //}

            //if (string.IsNullOrEmpty(this.Confirm))
            //{
            //    await Application.Current.MainPage.DisplayAlert(
            //        Languages.Error,
            //        Languages.ConfirmValidation,
            //        Languages.Accept);
            //    return;
            //}

            //if (this.NewPassword != this.Confirm)
            //{
            //    await Application.Current.MainPage.DisplayAlert(
            //        Languages.Error,
            //        Languages.ConfirmValidation2,
            //        Languages.Accept);
            //    return;
            //}

            //this.IsRunning = true;
            //this.IsEnabled = false;

            //var connection = await this.apiService.CheckConnection();

            //if (!connection.IsSuccess)
            //{
            //    this.IsRunning = false;
            //    this.IsEnabled = true;
            //    await Application.Current.MainPage.DisplayAlert(
            //        Languages.Error,
            //        connection.Message,
            //        Languages.Accept);
            //    return;
            //}

            //var request = new ChangePasswordRequest
            //{
            //    CurrentPassword = this.CurrentPassword,
            //    Email = MainViewModel.GetInstance().User.Email,
            //    NewPassword = this.NewPassword,
            //};

            //var apiSecurity = Application.Current.Resources["APISecurity"].ToString();
            //var response = await this.apiService.ChangePassword(
            //    apiSecurity,
            //    "/api",
            //    "/Users/ChangePassword",
            //    MainViewModel.GetInstance().TokenType,
            //    MainViewModel.GetInstance().Token,
            //    request);

            //if (!response.IsSuccess)
            //{
            //    this.IsRunning = false;
            //    this.IsEnabled = true;
            //    await Application.Current.MainPage.DisplayAlert(
            //        Languages.Error,
            //        response.Message,
            //        Languages.Accept);
            //    return;
            //}

            //MainViewModel.GetInstance().User.Password = this.NewPassword;
            //this.dataService.Update(MainViewModel.GetInstance().User);

            //this.IsRunning = false;
            //this.IsEnabled = true;

            //await Application.Current.MainPage.DisplayAlert(
            //    Languages.ConfirmLabel,
            //    Languages.ChagePasswordConfirm,
            //    Languages.Accept);
            //await App.Navigator.PopAsync();
        }
        #endregion

    }
}
