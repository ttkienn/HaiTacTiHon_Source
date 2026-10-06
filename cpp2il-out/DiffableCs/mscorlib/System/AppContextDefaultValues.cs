namespace System;

internal static class AppContextDefaultValues
{
	internal static readonly string SwitchEnforceJapaneseEraYearRanges; //Field offset: 0x0
	internal static readonly string SwitchFormatJapaneseFirstYearAsANumber; //Field offset: 0x8
	internal static readonly string SwitchEnforceLegacyJapaneseDateParsing; //Field offset: 0x10

	private static AppContextDefaultValues() { }

	public static void PopulateDefaultValues() { }

	public static bool TryGetSwitchOverride(string switchName, out bool overrideValue) { }

}

