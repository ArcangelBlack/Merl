using System.Threading.Tasks;
using MrelsApp.Views;
using MrelsApp.Views.HelpsViews;
using MrelsApp.Views.UserViews;
using MrelsApp.Views.WorkoutViews;
using Xamarin.Forms;
using LoginPage = MrelsApp.Views.MainViews.LoginPage;

namespace MrelsApp.Services
{
    public class NavigationService
    {
        public async Task Navigate(string pageName)
        {
            App.Master.IsPresented = false;

            switch (pageName)
            {
                case "WorkoutOverviewPage":
                    {
                        await App.Navigator.PushAsync(new WorkoutOverviewPage());
                    }
                    break;
                case "UserPage":
                    {
                        await App.Navigator.PushAsync(new UserPage());
                    }
                    break;
                case "ChatBoxPage":
                    {
                        await App.Navigator.PushAsync(new ChatBoxPage());
                    }
                    break;
                case "CalendarPage":
                    {
                        await App.Navigator.PushAsync(new CalendarPage());
                    }
                    break;
                case "TrainingPage":
                    {
                        await App.Navigator.PushAsync(new TrainingPage());
                    }
                    break;
                case "FeedBackPage":
                    {
                        await App.Navigator.PushAsync(new FeedBackPage());
                    }
                    break;
                case "ConfigurationPage":
                    {
                        await App.Navigator.PushAsync(new ConfigurationPage());
                    }
                    break;
                case "LoginPage":
                    {
                        Application.Current.MainPage = new NavigationPage(new LoginPage());
                    }
                    break;
                default:
                    await App.Navigator.PushAsync(new UserPage());
                    break;
            }
        }

        //private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var item = e.SelectedItem as B4CoachMasterMenuItem;
        //    if (item == null)
        //        return;

        //    var page = (Page)Activator.CreateInstance(item.TargetType);
        //    page.Title = item.Title;

        //    Detail = new NavigationPage(page);
        //    IsPresented = false;

        //    MasterPage.ListView.SelectedItem = null;
        //}

        public async Task Back()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

    }
}
