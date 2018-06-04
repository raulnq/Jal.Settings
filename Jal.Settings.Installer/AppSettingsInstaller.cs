using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Jal.Settings.Impl;
using Jal.Settings.Interface;

namespace Jal.Settings.Installer
{
    public class AppSettingsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<ISectionExtractor>().ImplementedBy<AppSectionExtractor>(),
                Component.For<ISettingsExtractor>().ImplementedBy<AppSettingsExtractor>());
        }
    }
}