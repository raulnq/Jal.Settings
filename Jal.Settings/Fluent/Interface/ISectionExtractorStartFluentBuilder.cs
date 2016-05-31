using Jal.Settings.Interface;

namespace Jal.Settings.Fluent.Interface
{
    public interface ISectionExtractorStartFluentBuilder : ISectionExtractorFluentBuilder
    {
        ISectionExtractorFluentBuilder UseSectionExtractor(ISectionExtractor sectionExtractor);
    }
}