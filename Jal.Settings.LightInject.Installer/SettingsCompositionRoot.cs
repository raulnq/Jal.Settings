using Jal.Settings.Impl;
using Jal.Settings.Interface;
using LightInject;

namespace Jal.Settings.LightInject.Installer
{
    public class SettingsCompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<ISectionExtractor, SectionExtractor>(new PerContainerLifetime());
            serviceRegistry.Register<ISettingsExtractor, SettingsExtractor>(new PerContainerLifetime());
        }
    }
}
