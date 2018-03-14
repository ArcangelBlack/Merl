using MrelsApp.ViewModels;

namespace MrelsApp.Infrastructure
{
    public class InstanceLocator
    {
        #region Constructor

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }

        #endregion

        #region Properties

        public MainViewModel Main { get; set; }

        #endregion
    }
}
