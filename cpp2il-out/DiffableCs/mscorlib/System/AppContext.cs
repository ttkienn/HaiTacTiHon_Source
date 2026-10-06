namespace System;

public static class AppContext
{
	[Flags]
	private enum SwitchValueState
	{
		HasFalseValue = 1,
		HasTrueValue = 2,
		HasLookedForOverride = 4,
		UnknownValue = 8,
	}

	private static readonly Dictionary<String, SwitchValueState> s_switchMap; //Field offset: 0x0
	private static bool s_defaultsInitialized; //Field offset: 0x8

	private static AppContext() { }

	private static void InitializeDefaultSwitchValues() { }

	public static bool TryGetSwitch(string switchName, out bool isEnabled) { }

}

