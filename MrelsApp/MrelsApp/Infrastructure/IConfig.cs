using SQLite.Net.Interop;

namespace MrelsApp.Infrastructure
{
    public interface IConfig
    {
        string DirectoryDb { get; }

        ISQLitePlatform Platform { get; }
    }
}
