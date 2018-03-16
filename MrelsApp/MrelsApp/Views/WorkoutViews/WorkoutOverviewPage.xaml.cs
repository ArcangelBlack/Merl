using System;
using MrelsApp.Models;
using MrelsApp.ViewModels;
using MrelsApp.ViewModels.WorkoutViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MrelsApp.Views.WorkoutViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WorkoutOverviewPage : ContentPage
	{
        //WorkoutOverviewViewModel viewModel;

        public WorkoutOverviewPage()
        {
            InitializeComponent();

            //BindingContext = viewModel = new WorkoutOverviewViewModel();
        }

        //async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        //{
        //    var item = args.SelectedItem as Item;
        //    if (item == null)
        //        return;

        //    await Navigation.PushAsync(new WorkoutDetailPage(new ItemDetailViewModel(item)));

        //    // Manually deselect item.
        //    ItemsListView.SelectedItem = null;
        //}

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();

        //    if (viewModel.Items.Count == 0)
        //        viewModel.LoadItemsCommand.Execute(null);
        //}
    }
}