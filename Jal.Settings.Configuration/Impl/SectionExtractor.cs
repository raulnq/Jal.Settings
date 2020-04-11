using System;
using Microsoft.Extensions.Configuration;

namespace Jal.Settings.Configuration
{
    public class SectionExtractor : ISectionExtractor
    {
        private readonly IConfiguration _configuration;

        public SectionExtractor(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static ISectionExtractor Current;

        public static ISectionExtractor Create(IConfiguration configuration)
        {
            return new SectionExtractor(configuration);
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