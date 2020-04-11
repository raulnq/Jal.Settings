using Microsoft.Extensions.DependencyInjection;

namespace Jal.Settings.Configuration.Microsoft.Extensions.DependencyInjection.Installer
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSettings(this IServiceCollection servicecollection)
        {
            servicecollection.AddSingleton<ISectionExtractor, SectionExtractor>();

            servicecollection.AddSingleton<ISettingsExtractor, SettingsExtractor>();

            return servicecollection;
        }
    }
}
