﻿using System.Windows.Input;
using MrelsApp.Services;
using MrelsApp.Utils;
using MrelsApp.ViewModels.WorkoutViewModels;
using MrelsApp.Views;
using Xamarin.Forms;

namespace MrelsApp.ViewModels.MainViewModels
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

            this.Email = "test@hotmail.com";
            this.Password = "1234";
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

        public ICommand LoginCommand => new RelayCommand(this.LoginCommandExecute);

        public ICommand IsRemembered => new RelayCommand(this.IsRememberedCommand);

        #region Commands

        private async void LoginCommandExecute()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                displayAlertService.DisplayAlertError("You must enter an email.");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                displayAlertService.DisplayAlertError("You must enter a password.");

                return;
            }

            this.IsBusy = true;

            if (this.Email != "test@hotmail.com" || this.Password != "1234")
            {
                displayAlertService.DisplayAlertError("Email or Password incorrect.");

                this.Password = string.Empty;

                this.IsBusy = false;

                return;
            }

            //Crear una sola instancia
            MainViewModel.GetInstanceMainViewModel().WorkoutOverviewVm = new WorkoutOverviewViewModel();
            MainViewModel.GetInstanceMainViewModel().B4CoachMasterMasterVm = new  B4CoachMasterMasterViewModel();

            Application.Current.MainPage = new B4CoachMaster();
        }
        private void IsRememberedCommand()
        {
            throw new System.NotImplementedException();
        }

        #endregion 
    }
}
