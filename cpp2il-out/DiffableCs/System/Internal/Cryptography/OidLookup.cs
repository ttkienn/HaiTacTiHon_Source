namespace Internal.Cryptography;

internal static class OidLookup
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal string <.cctor>b__10_0(KeyValuePair<String, String> kvp) { }

		internal string <.cctor>b__10_1(KeyValuePair<String, String> kvp) { }

	}

	private static readonly ConcurrentDictionary<String, String> s_lateBoundOidToFriendlyName; //Field offset: 0x0
	private static readonly ConcurrentDictionary<String, String> s_lateBoundFriendlyNameToOid; //Field offset: 0x8
	private static readonly Dictionary<String, String> s_friendlyNameToOid; //Field offset: 0x10
	private static readonly Dictionary<String, String> s_oidToFriendlyName; //Field offset: 0x18
	private static readonly Dictionary<String, String> s_compatOids; //Field offset: 0x20

	private static OidLookup() { }

	private static string NativeFriendlyNameToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	private static string NativeOidToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	private static bool ShouldUseCache(OidGroup oidGroup) { }

	public static string ToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	public static string ToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

}

