using System.Globalization;

namespace MrelsApp.Infrastructure
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();

        void SetLocale(CultureInfo ci);
    }
}
