using System.Configuration;
using Jal.Settings.Fluent;
using Jal.Settings.Fluent.Interface;
using Jal.Settings.Interface;

namespace Jal.Settings.Impl
{
    public class SectionExtractor : ISectionExtractor
    {
        public static ISectionExtractor Current;

        public static ISectionExtractorFluentBuilder Builder => new SectionExtractorFluentBuilder();

        public T GetSection<T>(string name) where T:class
        {
            try
            {
                return ConfigurationManager.GetSection(name) as T;
            }
            catch (ConfigurationErrorsException ce)
            {
                throw new ConfigurationErrorsException(
                    $"Section \"{name}\" is missing from app configuration file", ce);
            }
            
        }
    }
}