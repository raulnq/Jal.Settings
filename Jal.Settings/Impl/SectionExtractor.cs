using System.Configuration;
using Jal.Settings.Interface;

namespace Jal.Settings.Impl
{
    public class SectionExtractor : ISectionExtractor
    {
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