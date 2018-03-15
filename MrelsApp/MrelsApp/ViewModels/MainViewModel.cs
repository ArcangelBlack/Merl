using MrelsApp.ViewModels.MainViewModels;
using MrelsApp.ViewModels.WorkoutViewModels;

namespace MrelsApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region ViewModels

        public LoginViewModel LoginVm { get; set; }

        public WorkoutOverviewViewModel WorkoutOverviewVm { get; set; }

        public WorkoutOverviewDetailViewModel WorkoutOverviewDetailVm { get; set; }

        public SubWorkoutDetailViewModel SubWorkoutDetailVm { get; set; }

        #endregion

        #region Constructor

        public MainViewModel()
        {
            instanceMainViewModel = this;
            this.LoginVm = new LoginViewModel();
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
