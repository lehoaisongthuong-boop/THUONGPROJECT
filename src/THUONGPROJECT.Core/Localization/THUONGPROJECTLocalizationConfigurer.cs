using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace THUONGPROJECT.Localization
{
    public static class THUONGPROJECTLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(THUONGPROJECTConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(THUONGPROJECTLocalizationConfigurer).GetAssembly(),
                        "THUONGPROJECT.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
