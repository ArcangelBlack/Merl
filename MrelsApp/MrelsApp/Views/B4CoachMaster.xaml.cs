using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MrelsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class B4CoachMaster : MasterDetailPage
    {
        public B4CoachMaster()
        {
            InitializeComponent();
            App.Navigator = Navigator;
            App.Master = this;
        }
    }
}