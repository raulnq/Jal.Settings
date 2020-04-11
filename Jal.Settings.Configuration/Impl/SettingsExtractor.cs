using System;
using System.Collections.Specialized;
using Microsoft.Extensions.Configuration;

namespace Jal.Settings.Configuration
{
    public class SettingsExtractor : ISettingsExtractor
    {

        public static ISettingsExtractor Current;

        public static ISettingsExtractor Create(IConfiguration configuration)
        {
            return new SettingsExtractor(configuration);
        }

        private readonly IConfiguration _configuration;

        public SettingsExtractor(IConfiguration configuration)
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