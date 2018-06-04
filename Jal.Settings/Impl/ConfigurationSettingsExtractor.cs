#if NETSTANDARD2_0
using System;
using System.Collections.Specialized;
using Jal.Settings.Interface;
using Microsoft.Extensions.Configuration;

namespace Jal.Settings.Impl
{
    public class ConfigurationSettingsExtractor : ISettingsExtractor
    {

        public static ISettingsExtractor Current;

        public static ISettingsExtractor Create(IConfiguration configuration)
        {
            return new ConfigurationSettingsExtractor(configuration);
        }

        private readonly IConfiguration _configuration;

        public ConfigurationSettingsExtractor(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public T Get<T>(string name, bool required = true, T defaultvalue = default(T))
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return defaultvalue;
            }
            var setting = _configuration[name];

            if (string.IsNullOrEmpty(setting))
                if (required)
                    throw new Exception($"{name} - is missing from app configuration file");
                else
                    return defaultvalue;

            return (T)Convert.ChangeType(_configuration[name], typeof(T));
        }

        public NameValueCollection All()
        {
            throw new NotSupportedException();
        }
    }
}
#endif