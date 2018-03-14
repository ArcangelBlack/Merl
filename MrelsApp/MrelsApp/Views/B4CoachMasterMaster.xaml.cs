using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MrelsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class B4CoachMasterMaster : ContentPage
    {
        public ListView ListView;

        public B4CoachMasterMaster()
        {
            InitializeComponent();

            BindingContext = new B4CoachMasterMasterViewModel();
            ListView = MenuItemsListView;
        }

        class B4CoachMasterMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<B4CoachMasterMenuItem> MenuItems { get; set; }
            
            public B4CoachMasterMasterViewModel()
            {
                MenuItems = new ObservableCollection<B4CoachMasterMenuItem>(new[]
                {
                    new B4CoachMasterMenuItem { Id = 0, Icon = "ic_b4_logo", Title = "Start workout" },
                    new B4CoachMasterMenuItem { Id = 1, Icon = "ic_shortcut_account_circle", Title = "Profile" },
                    new B4CoachMasterMenuItem { Id = 2, Icon = "ic_shortcut_chat", Title = "Chat" },
                    new B4CoachMasterMenuItem { Id = 3, Icon = "ic_shortcut_date_range", Title = "Calendar" },
                    new B4CoachMasterMenuItem { Id = 4, Icon = "ic_shortcut_multiline_chart", Title = "Training program" },
                    new B4CoachMasterMenuItem { Id = 5, Icon = "ic_shortcut_notifications_active", Title = "FeedBack" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}