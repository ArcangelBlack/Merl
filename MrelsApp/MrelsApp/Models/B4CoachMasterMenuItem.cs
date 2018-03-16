using System;

namespace MrelsApp.Models
{

    public class B4CoachMasterMenuItem
    {
        public B4CoachMasterMenuItem()
        {
        }
        public int Id { get; set; }

        public string Icon { get; set; }

        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}