using LightInject;
using Microsoft.Extensions.Configuration;

namespace Jal.Settings.Configuration.LightInject.Installer
{
    public static class ServiceContainerExtension
    {
        public static void AddSettings(this IServiceContainer container, IConfiguration configuration)
        {
            container.Register<IConfiguration>(x => configuration, new PerContainerLifetime());
            container.Register<ISectionExtractor, SectionExtractor>(new PerContainerLifetime());
            container.Register<ISettingsExtractor, SettingsExtractor>(new PerContainerLifetime());
        }
    }
}