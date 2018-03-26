﻿using System.Windows.Input;
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
            this.Title = item.Description;
            this.ItemDetail = item;
        }

        #endregion

        #region Properties

        public SubWorkoutModel ItemDetail { get; set; }

        public ICommand NextCommand => new RelayCommand(this.NextCommandExecute);

        public ICommand PauseCommand => new RelayCommand(this.PauseCommandExecute);

        #endregion

        #region Commands

        private async void NextCommandExecute()
        {
            MainViewModel.GetInstanceMainViewModel().WorkoutSummaryVm = new WorkoutSummaryViewModel();
            await App.Navigator.PushAsync(new WorkoutSummaryPage());
        }

        private async void PauseCommandExecute()
        {
            MainViewModel.GetInstanceMainViewModel().BreakVm = new BreakViewModel();
            await App.Navigator.PushAsync(new BreakPage());
        }


        #endregion
    }
}
