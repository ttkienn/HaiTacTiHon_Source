namespace UnityEngine;

[NativeHeader("Modules/JSONSerialize/Public/JsonUtility.bindings.h")]
public static class JsonUtility
{

	public static T FromJson(string json) { }

	public static object FromJson(string json, Type type) { }

	[FreeFunction("FromJsonInternal", True, ThrowsException = True)]
	[ThreadSafe]
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	public static string ToJson(object obj) { }

	public static string ToJson(object obj, bool prettyPrint) { }

	[FreeFunction("ToJsonInternal", True)]
	[ThreadSafe]
	private static string ToJsonInternal(object obj, bool prettyPrint) { }

}

