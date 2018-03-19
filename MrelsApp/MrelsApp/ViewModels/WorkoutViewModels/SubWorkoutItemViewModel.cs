using System.Windows.Input;
using MrelsApp.Models;
using MrelsApp.Utils;
using MrelsApp.Views.WorkoutViews;

namespace MrelsApp.ViewModels.WorkoutViewModels
{
    public class SubWorkoutItemViewModel : SubWorkoutModel
    {
        #region Properties

        public ICommand SelectSubWorkoutCommand => new RelayCommand(this.SelectSubWorkoutCommandExecute);

        #endregion

        #region Commands

        private async void SelectSubWorkoutCommandExecute()
        {
            MainViewModel.GetInstanceMainViewModel().SubWorkoutDetailVm = new SubWorkoutDetailViewModel(this);
            await App.Navigator.PushAsync(new SubWorkoutDetailPage());
        }

        #endregion
    }
}
