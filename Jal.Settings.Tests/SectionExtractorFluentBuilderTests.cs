using Jal.Settings.Fluent;
using Jal.Settings.Impl;
using NUnit.Framework;
using Shouldly;

namespace Jal.Settings.Tests
{
    public class SectionExtractorFluentBuilderTests
    {
        [Test]
        public void Create_With_ShouldNotBeNull()
        {
            var sut = new SectionExtractorFluentBuilder();

            var instance = sut.Create;

            instance.ShouldNotBeNull();

            instance.ShouldBeOfType<SectionExtractor>();
        }
    }
}