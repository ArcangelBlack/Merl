using System.Windows.Input;
using MrelsApp.Models;
using MrelsApp.Utils;
using MrelsApp.Views.WorkoutViews;

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

            await App.Navigator.PushAsync(new WorkoutDetailPage());
        }

        #endregion
    }
}
