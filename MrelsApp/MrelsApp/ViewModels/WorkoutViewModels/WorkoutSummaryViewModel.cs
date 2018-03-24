using System.Windows.Input;
using MrelsApp.Utils;
using MrelsApp.Views.WorkoutViews;

namespace MrelsApp.ViewModels.WorkoutViewModels
{
    public class WorkoutSummaryViewModel : BaseViewModel
    {

        #region Properties

        public ICommand NextCommand => new RelayCommand(this.NextCommandExecute);

        #endregion

        #region Commands

        private async void NextCommandExecute()
        {
            MainViewModel.GetInstanceMainViewModel().FeelVm = new FeelViewModel();
            await App.Navigator.PushAsync(new FeelPage());
        }

        #endregion
    }
}
