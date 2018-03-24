using System;
using MrelsApp.Infrastructure;
using SQLite.Net.Interop;

[assembly: Xamarin.Forms.Dependency(typeof(MrelsApp.iOS.Insfrastructure.Configuration))]
namespace MrelsApp.iOS.Insfrastructure
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
                    var directory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    directoryDb = System.IO.Path.Combine(directory, "..", "Library");
                }
                return directoryDb;
            }
        }

        public ISQLitePlatform Platform => platform ?? (platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS());
    }
}