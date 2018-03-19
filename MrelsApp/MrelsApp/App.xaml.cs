using MrelsApp.ViewModels;
using MrelsApp.Views;
using Xamarin.Forms;

namespace MrelsApp
{
    public partial class App : Application
    {
        #region Properties

        public static NavigationPage Navigator { get; internal set; }

        public static B4CoachMaster Master { get; internal set; }

        #endregion

        public App()
        {
            InitializeComponent();

            this.MainPage = new NavigationPage(new InitPage());

            //Validar que en token es valido
            //var mainVm = MainViewModel.GetInstanceMainViewModel();
            //mainVm.Token
            //mainVm.TokenType
            //this.MainPage = new B4CoachMaster();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
