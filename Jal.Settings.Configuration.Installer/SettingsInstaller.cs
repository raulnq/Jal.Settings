using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Jal.Settings.Configuration.Impl;
using Jal.Settings.Interface;
using Microsoft.Extensions.Configuration;

namespace Jal.Settings.Configuration.Installer
{
    public class SettingsInstaller : IWindsorInstaller
    {
        private readonly IConfiguration _configuration;

        public SettingsInstaller(IConfiguration configuration)
        {
            _configuration = configuration;
        } 

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(
                Component.For<IConfiguration>().Instance(_configuration),
                Component.For<ISectionExtractor>().ImplementedBy<SectionExtractor>(),
                Component.For<ISettingsExtractor>().ImplementedBy<SettingsExtractor>());
        }
    }
}