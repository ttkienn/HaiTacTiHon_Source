namespace UnityEngine;

[NativeHeader("Runtime/Utilities/PropertyName.h")]
internal class PropertyNameUtils
{

	[FreeFunction(IsThreadSafe = True)]
	public static PropertyName PropertyNameFromString(string name) { }

	private static void PropertyNameFromString_Injected(string name, out PropertyName ret) { }

}

