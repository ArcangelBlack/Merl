using System;
using MrelsApp.Models;
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
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as B4CoachMasterMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}