using Jal.Settings.Configuration.Impl;
using Jal.Settings.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Jal.Settings.Configuration.Microsoft.Extensions.DependencyInjection.Installer
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSettings(this IServiceCollection servicecollection, IConfiguration configuration)
        {
            servicecollection.AddSingleton<ISectionExtractor, SectionExtractor>();

            servicecollection.AddSingleton<ISettingsExtractor, SettingsExtractor>();

            servicecollection.AddSingleton<IConfiguration>(x => configuration);

            return servicecollection;
        }
    }
}
