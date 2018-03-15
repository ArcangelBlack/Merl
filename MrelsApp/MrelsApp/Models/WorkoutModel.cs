using System.Collections.ObjectModel;

namespace MrelsApp.Models
{
    public class WorkoutModel
    {
        public string Id { get; set; }

        public string ImageUri { get; set; }

        public string Text { get; set; }

        public string Description { get; set; }

        public ObservableCollection<SubWorkoutModel> SubWorkoutModels { get; set; }
    }
}