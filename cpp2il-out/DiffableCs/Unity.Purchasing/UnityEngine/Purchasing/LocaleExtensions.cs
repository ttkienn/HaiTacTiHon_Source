namespace UnityEngine.Purchasing;

[Extension]
public static class LocaleExtensions
{
	private static readonly String[] Labels; //Field offset: 0x0
	private static readonly TranslationLocale[] GoogleLocales; //Field offset: 0x8
	private static readonly TranslationLocale[] AppleLocales; //Field offset: 0x10
	private static String[] LabelsWithSupportedPlatforms; //Field offset: 0x18

	private static LocaleExtensions() { }

	public static String[] GetLabelsWithSupportedPlatforms() { }

	[Extension]
	public static bool SupportedOnApple(TranslationLocale locale) { }

	[Extension]
	public static bool SupportedOnGoogle(TranslationLocale locale) { }

}

