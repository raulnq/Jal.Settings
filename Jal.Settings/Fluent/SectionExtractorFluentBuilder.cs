using Jal.Settings.Fluent.Interface;
using Jal.Settings.Impl;
using Jal.Settings.Interface;

namespace Jal.Settings.Fluent
{
    public class SectionExtractorFluentBuilder : ISectionExtractorFluentBuilder
    {
        public ISectionExtractor Create => new SectionExtractor();
    }
}
