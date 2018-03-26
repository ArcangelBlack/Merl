using System.Windows.Input;
using MrelsApp.Utils;

namespace MrelsApp.ViewModels.UserViewModels
{
    public class UserViewModel : BaseViewModel
    {
        #region Fields

        #endregion

        #region Properties

        public ICommand SaveCommand => new RelayCommand(this.SaveCommandExecute);

        #endregion

        #region Commands

        private void SaveCommandExecute()
        {
            //MainViewModel.GetInstanceMainViewModel().UserVm
        }

        #endregion
    }
}
