using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Xamarin.Forms;

namespace MrelsApp.ViewModels.WorkoutViewModels
{
    public class WorkoutOverviewViewModel : BaseViewModel
    {
        #region Fields

        private ObservableCollection<WorkoutOverviewItemViewModel> items;

        #endregion


        public Command LoadItemsCommand { get; set; }

        public WorkoutOverviewViewModel()
        {
            this.Title = "Workout Overview";
            this.Items = new ObservableCollection<WorkoutOverviewItemViewModel>();

            this.ExecuteLoadItemsCommand();

            //MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            //{
            //    var _item = item as Item;
            //    Items.Add(_item);
            //await DataStore.AddItemAsync(_item);
            //});
        }

        #region Properties

        public ObservableCollection<WorkoutOverviewItemViewModel> Items
        {
            get => items;
            set => this.SetProperty(ref this.items, value);
        }

        #endregion

        public async void ExecuteLoadItemsCommand()
        {
            if (this.IsBusy)
                return;

            this.IsBusy = true;

            try
            {
                this.Items.Clear();

                var itemsTmp = new ObservableCollection<WorkoutOverviewItemViewModel>();
                
                var itemsResult = await DataStore.GetItemsAsync(true);
                foreach (var item in itemsResult)
                {
                    var newItem = new WorkoutOverviewItemViewModel
                    {
                        Id = item.Id,
                        Description = item.Description,
                        ImageUri = item.ImageUri,
                        Text = item.Text
                    };
                    itemsTmp.Add(newItem);
                }

                this.Items = itemsTmp;
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
    }
}