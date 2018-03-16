using MrelsApp.ViewModels;
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
            ListView = MenuItemssListView;
        }
    }
}