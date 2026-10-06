namespace Unity.Collections;

[Extension]
public static class NativeSliceExtensions
{

	[Extension]
	public static NativeSlice<T> Slice(NativeArray<T> thisArray, int start, int length) { }

	[Extension]
	public static NativeSlice<T> Slice(NativeSlice<T> thisSlice, int start, int length) { }

}

