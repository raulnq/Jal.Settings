using Castle.Windsor;
using Jal.Settings.Installer;
using Jal.Settings.Interface;
using NUnit.Framework;
using Shouldly;

namespace Jal.Settings.Tests
{
    public class SettingsInstallerTests
    {
        [Test]
        public void Install_With_ShouldNotBeNull()
        {
            var container = new WindsorContainer();

            container.Install(new AppSettingsInstaller());

            var setting = container.Resolve<ISettingsExtractor>();

            setting.ShouldNotBeNull();

            var section = container.Resolve<ISectionExtractor>();

            section.ShouldNotBeNull();
        }
    }
}