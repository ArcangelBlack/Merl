using System.Windows.Input;
using MrelsApp.Models;
using MrelsApp.Utils;
using MrelsApp.Views.WorkoutViews;
using Xamarin.Forms;

namespace MrelsApp.ViewModels.WorkoutViewModels
{
    public class WorkoutOverviewItemViewModel : WorkoutModel
    {
        #region Properties

        public ICommand SelectWorkoutCommand => new RelayCommand(this.SelectWorkoutCommandExecute);

        #endregion

        #region Commands

        private async void SelectWorkoutCommandExecute()
        {
            MainViewModel.GetInstanceMainViewModel().WorkoutOverviewDetailVm = new WorkoutOverviewDetailViewModel(this);
            await Application.Current.MainPage.Navigation.PushAsync(new NavigationPage(new WorkoutDetailPage()));
        }

        #endregion
    }
}
