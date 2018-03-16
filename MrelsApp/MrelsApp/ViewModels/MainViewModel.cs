using MrelsApp.ViewModels.MainViewModels;
using MrelsApp.ViewModels.UserViewModels;
using MrelsApp.ViewModels.WorkoutViewModels;

namespace MrelsApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region ViewModels

        public InitViewModel InitVm { get; set; }

        public LoginViewModel LoginVm { get; set; }

        public UserViewModel UserVm { get; set; }

        public WorkoutOverviewViewModel WorkoutOverviewVm { get; set; }

        public WorkoutOverviewDetailViewModel WorkoutOverviewDetailVm { get; set; }

        public SubWorkoutDetailViewModel SubWorkoutDetailVm { get; set; }

        #endregion

        #region Constructor

        public MainViewModel()
        {
            instanceMainViewModel = this;
            this.InitVm = new InitViewModel();
        }

        #endregion

        private static MainViewModel instanceMainViewModel;

        public static MainViewModel GetInstanceMainViewModel()
        {
            if (instanceMainViewModel != null)
            {
                return instanceMainViewModel;
            }

            return new MainViewModel();
        }

    }
}
