using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AbpDemoOne.Localization
{
    public static class AbpDemoOneLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AbpDemoOneConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AbpDemoOneLocalizationConfigurer).GetAssembly(),
                        "AbpDemoOne.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
