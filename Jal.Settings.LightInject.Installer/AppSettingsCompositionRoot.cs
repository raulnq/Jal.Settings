using Jal.Settings.Impl;
using Jal.Settings.Interface;
using LightInject;

namespace Jal.Settings.LightInject.Installer
{
    public class AppSettingsCompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<ISectionExtractor, AppSectionExtractor>(new PerContainerLifetime());
            serviceRegistry.Register<ISettingsExtractor, AppSettingsExtractor>(new PerContainerLifetime());
        }
    }
}
