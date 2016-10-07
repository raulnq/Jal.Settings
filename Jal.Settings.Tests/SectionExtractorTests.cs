using System.Configuration;
using Jal.Settings.Impl;
using NUnit.Framework;
using Shouldly;

namespace Jal.Settings.Tests
{
    public class SectionExtractorTests
    {
        [Test]
        public void GetSection_With_ShouldNotBeNull()
        {
            var sut = new SectionExtractor();

            var section = sut.GetSection<ConnectionStringsSection>("connectionStrings");

            section.ShouldNotBeNull();
        }

        [Test]
        public void GetSection_WithNonExistingSection_ShouldNotBeNull()
        {
            var sut = new SectionExtractor();

            var section = sut.GetSection<ConnectionStringsSection>("connectionStrings2");

            section.ShouldBeNull();
        }

        [Test]
        public void GetSection_WithNoValidSection_ShouldNotBeNull()
        {
            var sut = new SectionExtractor();

            var section = sut.GetSection<string>("connectionStrings");

            section.ShouldBeNull();
        }
    }
}