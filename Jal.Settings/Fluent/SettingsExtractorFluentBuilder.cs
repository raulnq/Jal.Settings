using Jal.Settings.Impl;
using Jal.Settings.Interface;
using Jal.Settings.Interface.Fluent;

namespace Jal.Settings.Fluent
{
    public class SettingsExtractorFluentBuilder : ISettingsExtractorFluentBuilder
    {
        public ISettingsExtractor Create
        {
            get
            {
                return new SettingsExtractor();
            }
        }
    }
}
