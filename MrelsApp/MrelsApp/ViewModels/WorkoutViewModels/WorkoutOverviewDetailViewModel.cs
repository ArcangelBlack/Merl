using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using MrelsApp.Models;

namespace MrelsApp.ViewModels.WorkoutViewModels
{
    public class WorkoutOverviewDetailViewModel : BaseViewModel
    {
        private ObservableCollection<SubWorkoutItemViewModel> subWorkoutList;

        #region Constructor

        public WorkoutOverviewDetailViewModel(WorkoutModel item = null)
        {
            this.SubWorkoutList = new ObservableCollection<SubWorkoutItemViewModel>();

            this.Title = item?.Text;
            this.ItemDetail = item;

            this.LoadSubWorkouts();
        }
        
        #endregion


        #region Properties

        public WorkoutModel ItemDetail { get; set; }

        public ObservableCollection<SubWorkoutItemViewModel> SubWorkoutList
        {
            get => subWorkoutList;
            set => this.SetProperty(ref subWorkoutList, value);
        }

        #endregion

        #region Commands

        private async void LoadSubWorkouts()
        {
            if (this.IsBusy)
                return;

            this.IsBusy = true;

            try
            {
                this.SubWorkoutList.Clear();

                var itemsTmp = new ObservableCollection<SubWorkoutItemViewModel>();

                var itemsResult = await SubDataStore.GetItemsFromParentIdAsync(ItemDetail.Id);
                foreach (var item in itemsResult)
                {
                    var newItem = new SubWorkoutItemViewModel
                    {
                        Id = item.Id,
                        ImageUri = item.ImageUri,
                        Description = item.Description,
                        Range =  item.Range,
                        Sensor = item.Sensor,
                        UrlVideo = item.UrlVideo
                    };
                    itemsTmp.Add(newItem);
                }

                this.SubWorkoutList = itemsTmp;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                this.IsBusy = false;
            }
        }

        #endregion
    }
}
