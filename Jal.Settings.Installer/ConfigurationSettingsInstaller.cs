#if NETSTANDARD2_0
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Jal.Settings.Impl;
using Jal.Settings.Interface;
using Microsoft.Extensions.Configuration;

namespace Jal.Settings.Installer
{
    public class ConfigurationSettingsInstaller : IWindsorInstaller
    {
        private readonly IConfiguration _configuration;

        public ConfigurationSettingsInstaller(IConfiguration configuration)
        {
            _configuration = configuration;
        } 

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(
                Component.For<IConfiguration>().Instance(_configuration),
                Component.For<ISectionExtractor>().ImplementedBy<ConfigurationSectionExtractor>(),
                Component.For<ISettingsExtractor>().ImplementedBy<ConfigurationSettingsExtractor>());
        }
    }
}
#endif