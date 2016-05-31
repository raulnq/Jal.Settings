using Jal.Settings.Interface;

namespace Jal.Settings.Fluent.Interface
{
    public interface ISettingsExtractorStartFluentBuilder : ISettingsExtractorFluentBuilder
    {
        ISettingsExtractorFluentBuilder UseSettingsExtractor(ISettingsExtractor settingsExtractor);
    }
}