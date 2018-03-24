using System.Windows.Input;
using MrelsApp.Models;
using MrelsApp.Utils;
using MrelsApp.Views.WorkoutViews;

namespace MrelsApp.ViewModels.WorkoutViewModels
{
    public class SubWorkoutDetailViewModel : BaseViewModel
    {
        #region Contructor

        public SubWorkoutDetailViewModel(SubWorkoutModel item = null)
        {
            this.ItemDetail = item;
        }

        #endregion

        #region Properties

        public SubWorkoutModel ItemDetail { get; set; }

        public ICommand NextCommand => new RelayCommand(this.NextCommandExecute);

        #endregion

        #region Commands

        private async void NextCommandExecute()
        {
            MainViewModel.GetInstanceMainViewModel().WorkoutSummaryVm = new WorkoutSummaryViewModel();
            await App.Navigator.PushAsync(new WorkoutSummaryPage());
        }

        #endregion
    }
}
