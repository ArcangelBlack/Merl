using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MrelsApp.Services
{
    public class NavigationService
    {
        public async Task Navigate(string pageName)
        {
            switch (pageName)
            {
                case "NewFlowerPage":
                    //await App.Current.MainPage.Navigation.PushAsync(new NewFlowerPage());
                    break;
                default:
                    break;
            }
        }

        public async Task Back()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

    }
}
