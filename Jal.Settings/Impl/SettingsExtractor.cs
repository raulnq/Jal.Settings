﻿using System;
using System.Collections.Specialized;
using System.Configuration;
using Jal.Settings.Fluent;
using Jal.Settings.Fluent.Interface;
using Jal.Settings.Interface;

namespace Jal.Settings.Impl
{
    public class SettingsExtractor : ISettingsExtractor
    {

        public static ISettingsExtractor Current;

        public static ISettingsExtractorFluentBuilder Builder => new SettingsExtractorFluentBuilder();

        public T Get<T>(string name, bool required = true, T defaultvalue=default(T))
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return defaultvalue;
            }
            var setting = ConfigurationManager.AppSettings[name];

            if (string.IsNullOrEmpty(setting))
                if (required)
                    throw new ConfigurationErrorsException($"{name} - is missing from app configuration file");
                else
                    return defaultvalue;

            return (T)Convert.ChangeType(ConfigurationManager.AppSettings[name], typeof(T));
        }

        public NameValueCollection All()
        {
            return ConfigurationManager.AppSettings;
        }
    }
}