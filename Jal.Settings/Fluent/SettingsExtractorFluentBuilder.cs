using System;
using Jal.Settings.Fluent.Interface;
using Jal.Settings.Impl;
using Jal.Settings.Interface;

namespace Jal.Settings.Fluent
{
    public class SettingsExtractorFluentBuilder : ISettingsExtractorFluentBuilder
    {
        public ISettingsExtractor Create => new SettingsExtractor();
    }
}
