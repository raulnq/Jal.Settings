using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Jal.Settings.Impl;
using Jal.Settings.Interface;

namespace Jal.Settings.Installer
{
    public class SettingsInstaller : IWindsorInstaller
    {
        #region IWindsorInstaller Members

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                //Settings registration - Singleton
                Component.For<ISectionExtractor>().ImplementedBy<SectionExtractor>(),
                Component.For<ISettingsExtractor>().ImplementedBy<SettingsExtractor>());
        }

        #endregion
    }
}