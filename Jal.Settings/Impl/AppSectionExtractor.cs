using System.Configuration;
using Jal.Settings.Interface;

namespace Jal.Settings.Impl
{
    public class AppSectionExtractor : ISectionExtractor
    {
        public static ISectionExtractor Current;

        public static ISectionExtractor Create()
        {
            return new AppSectionExtractor();
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
                    $"Section \"{name}\" is missing from app configuration file", ce);
            }
            
        }
    }
}