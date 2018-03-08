using MrelsApp.Models;
using MrelsApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MrelsApp.Views.WorkoutViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WorkoutDetailPage : ContentPage
	{
        ItemDetailViewModel viewModel;

        public WorkoutDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public WorkoutDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}