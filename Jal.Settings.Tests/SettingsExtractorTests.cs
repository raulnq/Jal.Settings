using System.Configuration;
using Jal.Settings.Impl;
using NUnit.Framework;
using Shouldly;

namespace Jal.Settings.Tests
{
    [TestFixture]
    public class SettingsExtractorTests
    {
        [Test]
        public void Get_With_ShouldNotBeNull()
        {
            var sut = new SettingsExtractor();

            var setting = sut.Get<string>("setting1");

            setting.ShouldNotBeNull();

            setting.ShouldBe("1");
        }

        [Test]
        public void Get_WithNonExistingSetting_ShouldThrowException()
        {
            var sut = new SettingsExtractor();

            Should.Throw<ConfigurationErrorsException>(() => { var setting = sut.Get<string>("setting2"); });
        }

        [Test]
        public void Get_WithNonExistingSetting_ShouldNotBeNull()
        {
            var sut = new SettingsExtractor();

            var setting = sut.Get<string>("setting2", false);

            setting.ShouldBeNull();
        }

        [Test]
        public void Get_WithNonExistingSettingAndDefault_ShouldNotBeNull()
        {
            var sut = new SettingsExtractor();

            var setting = sut.Get<string>("setting2", false, "2");

            setting.ShouldNotBeNull();

            setting.ShouldBe("2");
        }

        [Test]
        public void Get_WithEmptyKey_ShouldNotBeNull()
        {
            var sut = new SettingsExtractor();

            var setting = sut.Get<string>("", false, "2");

            setting.ShouldNotBeNull();

            setting.ShouldBe("2");
        }

        [Test]
        public void ALl_With_ShouldNotBeNull()
        {
            var sut = new SettingsExtractor();

            var settings = sut.All();

            settings.ShouldNotBeNull();
        }

        [Test]
        public void Builder_With_ShouldNotBeNull()
        {
            var builder = SettingsExtractor.Builder;

            builder.ShouldNotBeNull();
        }
    }
}
