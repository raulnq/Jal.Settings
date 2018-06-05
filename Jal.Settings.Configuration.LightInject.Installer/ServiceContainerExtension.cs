using Jal.Settings.Interface;
using LightInject;
using Microsoft.Extensions.Configuration;
using Jal.Settings.Configuration.Impl;

namespace Jal.Settings.Configuration.LightInject.Installer
{
    public static class ServiceContainerExtension
    {
        public static void RegisterSettings(this IServiceContainer container, IConfiguration configuration)
        {
            container.Register<IConfiguration>(x => configuration, new PerContainerLifetime());
            container.Register<ISectionExtractor, SectionExtractor>(new PerContainerLifetime());
            container.Register<ISettingsExtractor, SettingsExtractor>(new PerContainerLifetime());
        }
    }
}