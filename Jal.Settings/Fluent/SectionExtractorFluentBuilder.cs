using Jal.Settings.Impl;
using Jal.Settings.Interface;
using Jal.Settings.Interface.Fluent;

namespace Jal.Settings.Fluent
{
    public class SectionExtractorFluentBuilder : ISectionExtractorFluentBuilder
    {
        public ISectionExtractor Create
        {
            get
            {
                return new SectionExtractor();
            }
        }
    }
}
