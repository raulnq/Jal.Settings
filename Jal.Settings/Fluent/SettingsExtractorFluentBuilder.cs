using System;
using Jal.Settings.Fluent.Interface;
using Jal.Settings.Impl;
using Jal.Settings.Interface;

namespace Jal.Settings.Fluent
{
    public class SettingsExtractorFluentBuilder : ISettingsExtractorStartFluentBuilder
    {
        private ISettingsExtractor _settingsExtractor;

        public ISettingsExtractor Create
        {
            get
            {
                if (_settingsExtractor != null)
                {
                    return _settingsExtractor;
                }

                return new SettingsExtractor();
            }
        }

        public ISettingsExtractorFluentBuilder UseSettingsExtractor(ISettingsExtractor settingsExtractor)
        {
            if (settingsExtractor == null)
            {
                throw new ArgumentNullException("settingsExtractor");
            }
            _settingsExtractor = settingsExtractor;

            return this;
        }
    }
}
