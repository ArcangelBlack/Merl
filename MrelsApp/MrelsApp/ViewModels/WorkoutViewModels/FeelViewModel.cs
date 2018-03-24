using System.Windows.Input;
using MrelsApp.Utils;
using MrelsApp.Views;

namespace MrelsApp.ViewModels.WorkoutViewModels
{
    public class FeelViewModel: BaseViewModel
    {
        #region Properties

        public ICommand NextCommand => new RelayCommand(this.NextCommandExecute);

        #endregion

        #region Commands

        private async void NextCommandExecute()
        {
            //MainViewModel.GetInstanceMainViewModel().WorkoutSummaryVm = new WorkoutSummaryViewModel();
            await App.Navigator.PushAsync(new ChatBoxPage());
        }

        #endregion
    }
}
