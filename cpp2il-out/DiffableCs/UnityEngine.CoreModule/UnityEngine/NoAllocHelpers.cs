namespace UnityEngine;

[NativeHeader("Runtime/Export/Scripting/NoAllocHelpers.bindings.h")]
internal sealed class NoAllocHelpers
{

	public static void EnsureListElemCount(List<T> list, int count) { }

	[FreeFunction("NoAllocHelpers_Bindings::ExtractArrayFromList")]
	public static Array ExtractArrayFromList(object list) { }

	[FreeFunction("NoAllocHelpers_Bindings::Internal_ResizeList")]
	internal static void Internal_ResizeList(object list, int size) { }

	public static void ResizeList(List<T> list, int size) { }

	public static int SafeLength(List<T> values) { }

}

