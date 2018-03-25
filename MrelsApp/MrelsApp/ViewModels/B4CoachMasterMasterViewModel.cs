using System.Collections.ObjectModel;
using MrelsApp.Models;

namespace MrelsApp.ViewModels
{
    public class B4CoachMasterMasterViewModel : BaseViewModel
    {
        public ObservableCollection<B4CoachMasterMenuItem> MenuItems { get; set; }

        public B4CoachMasterMasterViewModel()
        {
            MenuItems = new ObservableCollection<B4CoachMasterMenuItem>(new[]
            {
                new B4CoachMasterMenuItem { Id = 0, Icon = "ic_logo", Title = "Start workout" , TargetType = "WorkoutOverviewPage" },
                new B4CoachMasterMenuItem { Id = 1, Icon = "ic_person", Title = "Profile", TargetType = "UserPage"},
                new B4CoachMasterMenuItem { Id = 2, Icon = "ic_chat", Title = "Chat", TargetType = "ChatBoxPage" },
                new B4CoachMasterMenuItem { Id = 3, Icon = "ic_date_range", Title = "Calendar", TargetType = "CalendarPage" },
                new B4CoachMasterMenuItem { Id = 4, Icon = "ic_multiline_chart", Title = "Training program" , TargetType = "TrainingPage"},
                //new B4CoachMasterMenuItem { Id = 5, Icon = "ic_sentiment_very_satisfied", Title = "FeedBack" , TargetType = "FeedBackPage"},
                new B4CoachMasterMenuItem { Id = 6, Icon = "ic_settings", Title = "Configuration" , TargetType = "ConfigurationPage"},
                new B4CoachMasterMenuItem { Id = 7, Icon = "ic_settings_power", Title = "Salir" , TargetType = "LoginPage"},
            });
        }
    }
}
