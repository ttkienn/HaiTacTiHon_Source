namespace System.Diagnostics;

public abstract class Switch
{
	private static List<WeakReference> switches; //Field offset: 0x0
	private static int s_LastCollectionCount; //Field offset: 0x8
	private readonly string description; //Field offset: 0x10
	private readonly string displayName; //Field offset: 0x18
	private string switchValueString; //Field offset: 0x20
	private string defaultValue; //Field offset: 0x28

	private static void _pruneCachedSwitches() { }

	private static Switch() { }

	protected Switch(string displayName, string description) { }

	protected Switch(string displayName, string description, string defaultSwitchValue) { }

}

