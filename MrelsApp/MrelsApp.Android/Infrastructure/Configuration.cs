using MrelsApp.Infrastructure;
using SQLite.Net.Interop;

[assembly: Xamarin.Forms.Dependency(typeof(MrelsApp.Droid.Infrastructure.Configuration))]
namespace MrelsApp.Droid.Infrastructure
{
    public class Configuration : IConfig
    {
        #region Fields

        private string directoryDb;

        private ISQLitePlatform platform;

        #endregion

        public string DirectoryDb
        {
            get
            {
                if (string.IsNullOrEmpty(directoryDb))
                {
                    directoryDb = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                }
                return directoryDb;
            }
        }

        public ISQLitePlatform Platform => platform ?? (platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid());
    }
}