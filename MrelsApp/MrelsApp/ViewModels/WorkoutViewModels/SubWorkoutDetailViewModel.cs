using System;
using System.Collections.Generic;
using System.Text;
using MrelsApp.Models;

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

        #endregion
    }
}
