using System.Collections.ObjectModel;
using MrelsApp.Models;

namespace MrelsApp.ViewModels
{
    class B4CoachMasterMasterViewModel : BaseViewModel
    {
        public ObservableCollection<B4CoachMasterMenuItem> MenuItems { get; set; }

        public B4CoachMasterMasterViewModel()
        {
            MenuItems = new ObservableCollection<B4CoachMasterMenuItem>(new[]
            {
                new B4CoachMasterMenuItem { Id = 0, Icon = "ic_b4_logo", Title = "Start workout" },
                new B4CoachMasterMenuItem { Id = 1, Icon = "ic_person", Title = "Profile" },
                new B4CoachMasterMenuItem { Id = 2, Icon = "ic_shortcut_chat", Title = "Chat" },
                new B4CoachMasterMenuItem { Id = 3, Icon = "ic_date_range", Title = "Calendar" },
                new B4CoachMasterMenuItem { Id = 4, Icon = "ic_multiline_chart", Title = "Training program" },
                new B4CoachMasterMenuItem { Id = 5, Icon = "ic_sentiment_very_satisfied", Title = "FeedBack" },
                new B4CoachMasterMenuItem { Id = 6, Icon = "ic_settings", Title = "Configuration" },
            });
        }
    }
}
