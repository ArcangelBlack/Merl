using Xamarin.Forms;

namespace MrelsApp.Services
{
    public class DisplayAlertService
    {
        public async void DisplayAlertError(string message)
        {
            await Application.Current.MainPage.DisplayAlert("Error", message, "Accept");
        }
    }
}
