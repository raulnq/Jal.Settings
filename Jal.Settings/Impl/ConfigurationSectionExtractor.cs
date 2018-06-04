#if NETSTANDARD2_0
using System;
using Jal.Settings.Interface;
using Microsoft.Extensions.Configuration;

namespace Jal.Settings.Impl
{
    public class ConfigurationSectionExtractor : ISectionExtractor
    {
        private readonly IConfiguration _configuration;

        public ConfigurationSectionExtractor(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static ISectionExtractor Current;

        public static ISectionExtractor Create(IConfiguration configuration)
        {
            return new ConfigurationSectionExtractor(configuration);
        }

        public T GetSection<T>(string name) where T : class
        {
            try
            {
                return _configuration.GetSection(name).Get<T>();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"Section \"{name}\" is missing from app configuration file", ex);
            }

        }
    }
}
#endif