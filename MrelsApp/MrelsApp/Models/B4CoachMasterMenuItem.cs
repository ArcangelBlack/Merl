using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrelsApp.Views
{

    public class B4CoachMasterMenuItem
    {
        public B4CoachMasterMenuItem()
        {
            TargetType = typeof(B4CoachMasterDetail);
        }
        public int Id { get; set; }

        public string Icon { get; set; }

        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}