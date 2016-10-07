using Jal.Settings.Fluent;
using Jal.Settings.Impl;
using NUnit.Framework;
using Shouldly;

namespace Jal.Settings.Tests
{
    public class SettingsExtractorFluentBuilderTests
    {
        [Test]
        public void Create_With_ShouldNotBeNull()
        {
            var sut = new SettingsExtractorFluentBuilder();

            var instance = sut.Create;

            instance.ShouldNotBeNull();

            instance.ShouldBeOfType<SettingsExtractor>();
        }
    }
}