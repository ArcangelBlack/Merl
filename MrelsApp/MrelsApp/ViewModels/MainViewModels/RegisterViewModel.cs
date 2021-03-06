﻿using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using MrelsApp.Models;
using MrelsApp.Services;
using MrelsApp.Utils;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;

namespace MrelsApp.ViewModels.MainViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        #region Attributes

        private bool isEnabled;

        private ImageSource imageSource;

        private DisplayAlertService displayAlertService;

        private MediaFile file;

        private ObservableCollection<TrainingPlanModel> trainingPlanList;

        private TrainingPlanModel selectTrainingPlan;

        #endregion

        #region Constructor

        public RegisterViewModel()
        {
            this.displayAlertService = new DisplayAlertService();
            //this.ImageSource = "no_image";+

            this.BirthdayDate = System.DateTime.Now;

            this.TrainingPlanList = new ObservableCollection<TrainingPlanModel>();
            this.LoadTrainingPlans();
        }

        #endregion

        #region Properties
        public ImageSource ImageSource
        {
            get => this.imageSource;
            set => this.SetProperty(ref this.imageSource, value);
        }

        public bool IsEnabled
        {
            get => this.isEnabled;
            set => this.SetProperty(ref this.isEnabled, value);
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public DateTime BirthdayDate { get; set; }

        public string Password { get; set; }

        public string Confirm { get; set; }

        public string PasswordStrength { get; set; }

        public ICommand SaveCommand => new RelayCommand(this.SaveCommandExecute);

        public ICommand ChangeImageCommand => new RelayCommand(this.ChangeImageExecute);

        //public FacebookViewModel FacebookVm { get; set; }

        //public TwitterViewModel TwitterVm { get; set; }

        //public YouTubeViewModel YouTubeVm { get; set; }

        //public InstagramViewModel InstagramVm { get; set; }

        public ObservableCollection<TrainingPlanModel> TrainingPlanList
        {
            get => this.trainingPlanList;
            set => this.SetProperty(ref this.trainingPlanList, value);
        }

        public TrainingPlanModel SelectTrainingPlan
        {
            get => this.selectTrainingPlan;
            set => this.SetProperty(ref this.selectTrainingPlan, value);
        }
        #endregion

        #region Commands

        private void SaveCommandExecute()
        {

            if (string.IsNullOrEmpty(this.LastName))
            {
                this.displayAlertService.DisplayAlertError("First Name");
            }

            if (string.IsNullOrEmpty(this.FirstName))
            {
                this.displayAlertService.DisplayAlertError("First Name");
            }

            if (string.IsNullOrEmpty(this.FirstName))
            {
                this.displayAlertService.DisplayAlertError("First Name");
            }
        }

        private async void ChangeImageExecute()
        {
            await CrossMedia.Current.Initialize();

            if (CrossMedia.Current.IsCameraAvailable &&
                CrossMedia.Current.IsTakePhotoSupported)
            {
                var source = await Application.Current.MainPage.DisplayActionSheet(
                    "Where do you want to take the image?",
                    "Cancel",
                    null,
                    "From gallery",
                    "From camera");

                if (source == "Cancel")
                {
                    this.file = null;
                    return;
                }

                if (source == "From camera")
                {
                    this.file = await CrossMedia.Current.TakePhotoAsync(
                        new StoreCameraMediaOptions
                        {
                            Directory = "Sample",
                            Name = "test.jpg",
                            PhotoSize = PhotoSize.Small,
                        }
                    );
                }
                else
                {
                    this.file = await CrossMedia.Current.PickPhotoAsync();
                }
            }
            else
            {
                this.file = await CrossMedia.Current.PickPhotoAsync();
            }

            if (this.file != null)
            {
                this.ImageSource = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    return stream;
                });
            }
        }

        private async void LoadTrainingPlans()
        {
            if (this.IsBusy)
                return;

            this.IsBusy = true;

            try
            {
                this.TrainingPlanList.Clear();

                var itemsTmp = new ObservableCollection<TrainingPlanModel>();

                var itemsResult = await DataStore.GetItemsAsync(true);
                foreach (var item in itemsResult)
                {
                    var newItem = new TrainingPlanModel
                    {
                        Id = item.Id,
                        Description = item.Text
                    };
                    itemsTmp.Add(newItem);
                }

                this.TrainingPlanList = itemsTmp;
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

        #endregion
    }

    public class FacebookViewModel { }

    public class TwitterViewModel { }

    public class YouTubeViewModel { }

    public class InstagramViewModel { }
}
