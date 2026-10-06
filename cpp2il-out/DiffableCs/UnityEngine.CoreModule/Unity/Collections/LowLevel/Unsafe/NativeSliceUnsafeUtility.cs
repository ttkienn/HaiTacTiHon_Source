namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
public static class NativeSliceUnsafeUtility
{

	public static NativeSlice<T> ConvertExistingDataToNativeSlice(Void* dataPointer, int stride, int length) { }

	[Extension]
	public static Void* GetUnsafePtr(NativeSlice<T> nativeSlice) { }

	[Extension]
	public static Void* GetUnsafeReadOnlyPtr(NativeSlice<T> nativeSlice) { }

}

