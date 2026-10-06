namespace UnityEngine.Purchasing;

[Extension]
internal static class ListExtension
{

	[Extension]
	internal static AndroidJavaObject ToJava(List<T> values) { }

	private static AndroidJavaObject ToJavaArray(List<T> values) { }

}

