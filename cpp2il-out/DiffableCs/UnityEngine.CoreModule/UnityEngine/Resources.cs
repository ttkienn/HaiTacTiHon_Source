namespace UnityEngine;

[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
public sealed class Resources
{

	[FreeFunction("GetScriptingBuiltinResource", ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public static object GetBuiltinResource(Type type, string path) { }

	public static T GetBuiltinResource(string path) { }

	public static object Load(string path) { }

	public static T Load(string path) { }

	public static object Load(string path, Type systemTypeInstance) { }

	[FreeFunction("Resources_Bindings::UnloadUnusedAssets")]
	public static AsyncOperation UnloadUnusedAssets() { }

}

