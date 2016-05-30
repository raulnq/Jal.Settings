using System;
using System.Configuration;
using Jal.Settings.Fluent;
using Jal.Settings.Interface;
using Jal.Settings.Interface.Fluent;

namespace Jal.Settings.Impl
{
    public class SettingsExtractor : ISettingsExtractor
    {

        public static ISettingsExtractor Current;

        public static ISettingsExtractorFluentBuilder Builder
        {
            get { return new SettingsExtractorFluentBuilder(); }
        }

        public T Get<T>(string name, bool required = true, T defaultvalue=default(T))
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return defaultvalue;
            }
            var setting = ConfigurationManager.AppSettings[name];

            if (string.IsNullOrEmpty(setting))
                if (required)
                    throw new ConfigurationErrorsException(string.Format("{0} - is missing from app configuration file", name));
                else
                    return defaultvalue;

            return (T)Convert.ChangeType(ConfigurationManager.AppSettings[name], typeof(T));
        }
    }
}