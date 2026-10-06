namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public static class DefaultStoreHelper
{
	private static string s_DefaultCustomStoreOverrideName; //Field offset: 0x0

	private static DefaultStoreHelper() { }

	private static string GetBuiltInDefaultStoreName() { }

	internal static AppStore GetDefaultBuiltInAppStore() { }

	public static string GetDefaultStoreName() { }

	public static void OverrideDefaultStoreName(string newDefaultStoreName) { }

}

