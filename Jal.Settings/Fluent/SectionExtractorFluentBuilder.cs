using System;
using Jal.Settings.Fluent.Interface;
using Jal.Settings.Impl;
using Jal.Settings.Interface;

namespace Jal.Settings.Fluent
{
    public class SectionExtractorFluentBuilder : ISectionExtractorStartFluentBuilder
    {
        private ISectionExtractor _sectionExtractor;

        public ISectionExtractor Create
        {
            get
            {
                if (_sectionExtractor != null)
                {
                    return _sectionExtractor;
                }

                return new SectionExtractor();
            }
        }

        public ISectionExtractorFluentBuilder UseSectionExtractor(ISectionExtractor sectionExtractor)
        {
            if (sectionExtractor == null)
            {
                throw new ArgumentNullException("sectionExtractor");
            }
            _sectionExtractor = sectionExtractor;

            return this;
        }
    }
}
