using System.Collections.Specialized;

namespace Jal.Settings
{
    public interface ISettingsExtractor
    {
        T Get<T>(string name, bool required = true, T defaultvalue = default(T));

        NameValueCollection All();
    }
}