namespace UnityEngine.Purchasing;

internal static class VersionCheck
{
	public struct Version
	{
		public int major; //Field offset: 0x0
		public int minor; //Field offset: 0x4
		public int patch; //Field offset: 0x8

	}


	public static bool Equal(string versionA, string versionB) { }

	public static bool GreaterThan(string versionA, string versionB) { }

	public static bool GreaterThanOrEqual(string versionA, string versionB) { }

	public static bool LessThan(string versionA, string versionB) { }

	public static bool LessThanOrEqual(string versionA, string versionB) { }

	public static int MajorVersion(string version) { }

	public static int MinorVersion(string version) { }

	public static Version Parse(string version) { }

	private static int PartialVersion(string version, int index) { }

	public static int PatchVersion(string version) { }

}

