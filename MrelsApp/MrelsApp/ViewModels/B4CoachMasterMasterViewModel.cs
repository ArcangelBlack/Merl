using System.Collections.ObjectModel;
using MrelsApp.Models;
using MrelsApp.Views;
using MrelsApp.Views.HelpsViews;
using MrelsApp.Views.UserViews;
using MrelsApp.Views.WorkoutViews;

namespace MrelsApp.ViewModels
{
    public class B4CoachMasterMasterViewModel : BaseViewModel
    {
        public ObservableCollection<B4CoachMasterMenuItem> MenuItems { get; set; }

        public B4CoachMasterMasterViewModel()
        {
            MenuItems = new ObservableCollection<B4CoachMasterMenuItem>(new[]
            {
                new B4CoachMasterMenuItem { Id = 0, Icon = "ic_logo", Title = "Start workout" , TargetType = typeof(WorkoutOverviewPage) },
                new B4CoachMasterMenuItem { Id = 1, Icon = "ic_person", Title = "Profile", TargetType = typeof(UserPage)},
                new B4CoachMasterMenuItem { Id = 2, Icon = "ic_chat", Title = "Chat", TargetType = typeof(ChatBoxPage) },
                new B4CoachMasterMenuItem { Id = 3, Icon = "ic_date_range", Title = "Calendar", TargetType = typeof(CalendarPage) },
                new B4CoachMasterMenuItem { Id = 4, Icon = "ic_multiline_chart", Title = "Training program" , TargetType = typeof(ChatBoxPage)},
                new B4CoachMasterMenuItem { Id = 5, Icon = "ic_sentiment_very_satisfied", Title = "FeedBack" , TargetType = typeof(FeedBackPage)},
                new B4CoachMasterMenuItem { Id = 6, Icon = "ic_settings", Title = "Configuration" , TargetType = typeof(ConfigurationPage)},
            });
        }
    }
}
