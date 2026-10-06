namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
public static class NativeArrayUnsafeUtility
{

	public static NativeArray<T> ConvertExistingDataToNativeArray(Void* dataPointer, int length, Allocator allocator) { }

	[Extension]
	public static Void* GetUnsafeReadOnlyPtr(NativeArray<T> nativeArray) { }

}

