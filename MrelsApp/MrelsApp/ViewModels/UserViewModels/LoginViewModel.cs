using System.Windows.Input;
using MrelsApp.Services;
using MrelsApp.Utils;

namespace MrelsApp.ViewModels.UserViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Fields

        private string email;

        private string password;

        private DisplayAlertService displayAlertService;

        #endregion

        #region Constructor

        public LoginViewModel()
        {
              this.displayAlertService = new DisplayAlertService();
        }

        #endregion

        public string Email
        {
            get => this.email;
            set => this.SetProperty(ref this.email, value);
        }

        public string Password
        {
            get => this.password;
            set => this.SetProperty(ref this.password, value);
        }

        public ICommand LoginCommand => new RelayCommand(LoginCommandExecute);

        public object DisplayAlertError { get; private set; }

        #region Commands

        private void LoginCommandExecute()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                displayAlertService.DisplayAlertError("You must enter an email");
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                displayAlertService.DisplayAlertError("You must enter a password");
            }

            if(this.Email != "test@hotmail.com" || this.Password != "1234")
            {
                displayAlertService.DisplayAlertError("You must enter a password");
            }


        }

        #endregion 
    }
}
