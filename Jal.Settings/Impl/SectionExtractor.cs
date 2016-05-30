using System.Configuration;
using Jal.Settings.Fluent;
using Jal.Settings.Interface;
using Jal.Settings.Interface.Fluent;

namespace Jal.Settings.Impl
{
    public class SectionExtractor : ISectionExtractor
    {
        public static ISectionExtractor Current;

        public static ISectionExtractorFluentBuilder Builder
        {
            get { return new SectionExtractorFluentBuilder(); }
        }

        public T GetSection<T>(string name) where T:class
        {
            try
            {
                return ConfigurationManager.GetSection(name) as T;
            }
            catch (ConfigurationErrorsException ce)
            {
                throw new ConfigurationErrorsException(
                    string.Format("Section \"{0}\" is missing from app configuration file", name), ce);
            }
            
        }
    }
}