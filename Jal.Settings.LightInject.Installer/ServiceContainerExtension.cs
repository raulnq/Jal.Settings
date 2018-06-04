#if NETSTANDARD2_0
using Jal.Settings.Impl;
using Jal.Settings.Interface;
using LightInject;
using Microsoft.Extensions.Configuration;

namespace Jal.Settings.LightInject.Installer
{
    public static class ServiceContainerExtension
    {
        public static void RegisterSettings(this IServiceContainer container, IConfiguration configuration)
        {
            container.Register<IConfiguration>(x => configuration, new PerContainerLifetime());
            container.Register<ISectionExtractor, ConfigurationSectionExtractor>(new PerContainerLifetime());
            container.Register<ISettingsExtractor, ConfigurationSettingsExtractor>(new PerContainerLifetime());
        }
    }
}
#endif