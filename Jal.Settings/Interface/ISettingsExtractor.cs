namespace Jal.Settings.Interface
{
    public interface ISettingsExtractor
    {
        T Get<T>(string name, bool required = true, T defaultvalue = default(T));
    }
}