using System.Collections.ObjectModel;
using MrelsApp.Models;
using MrelsApp.ViewModels.MainViewModels;
using MrelsApp.ViewModels.UserViewModels;
using MrelsApp.ViewModels.WorkoutViewModels;
using MrelsApp.Views;
using MrelsApp.Views.HelpsViews;
using MrelsApp.Views.UserViews;
using MrelsApp.Views.WorkoutViews;

namespace MrelsApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Fields

        private static MainViewModel instanceMainViewModel;

        #endregion

        #region ViewModels

        public InitViewModel InitVm { get; set; }

        public LoginViewModel LoginVm { get; set; }

        public RegisterViewModel RegisterVm { get; set; }

        public B4CoachMasterMasterViewModel B4CoachMasterMasterVm { get; set; }

        public UserViewModel UserVm { get; set; }

        public WorkoutOverviewViewModel WorkoutOverviewVm { get; set; }

        public WorkoutOverviewDetailViewModel WorkoutOverviewDetailVm { get; set; }

        public SubWorkoutDetailViewModel SubWorkoutDetailVm { get; set; }

        public WorkoutSummaryViewModel WorkoutSummaryVm { get; set; }

        #endregion

        #region Constructor

        public MainViewModel()
        {
            instanceMainViewModel = this;
            this.InitVm = new InitViewModel();
        }

        #endregion

        #region Methods

        public static MainViewModel GetInstanceMainViewModel()
        {
            if (instanceMainViewModel != null)
            {
                return instanceMainViewModel;
            }

            return new MainViewModel();
        }

        #endregion
    }
}
