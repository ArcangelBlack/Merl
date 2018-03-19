using System.Windows.Input;
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

        #endregion

        #region Constructor

        public RegisterViewModel()
        {
            this.displayAlertService = new DisplayAlertService();
            //this.ImageSource = "no_image";
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

        //public string BirthdayDate { get; set; }

        public string Password { get; set; }

        public string Confirm { get; set; }

        public string PasswordStrength { get; set; }

        public ICommand SaveCommand => new RelayCommand(this.SaveCommandExecute);

        public ICommand ChangeImageCommand => new RelayCommand(this.ChangeImageExecute);

        //public FacebookViewModel FacebookVm { get; set; }

        //public TwitterViewModel TwitterVm { get; set; }
        
        //public YouTubeViewModel YouTubeVm { get; set; }

        //public InstagramViewModel InstagramVm { get; set; }

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

        #endregion
    }

    public class FacebookViewModel { }

    public class TwitterViewModel { }

    public class YouTubeViewModel { }

    public class InstagramViewModel { }
}
