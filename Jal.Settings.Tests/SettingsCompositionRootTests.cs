using Jal.Settings.Interface;
using Jal.Settings.LightInject.Installer;
using LightInject;
using NUnit.Framework;
using Shouldly;

namespace Jal.Settings.Tests
{
    public class SettingsCompositionRootTests
    {
        [Test]
        public void Install_With_ShouldNotBeNull()
        {
            var container = new ServiceContainer();

            container.RegisterFrom<AppSettingsCompositionRoot>();

            var setting = container.GetInstance<ISettingsExtractor>();

            setting.ShouldNotBeNull();

            var section = container.GetInstance<ISectionExtractor>();

            section.ShouldNotBeNull();
        }
    }
}