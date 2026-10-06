namespace Unity.Profiling.LowLevel.Unsafe;

[IgnoredByDeepProfiler]
[NativeHeader("Runtime/Profiler/ScriptBindings/ProfilerUnsafeUtility.bindings.h")]
[UsedByNativeCode]
public static class ProfilerUnsafeUtility
{

	[ThreadSafe]
	public static void BeginSample(IntPtr markerPtr) { }

	[ThreadSafe]
	internal static ushort CreateCategory__Unmanaged(Byte* name, int nameLen, ProfilerCategoryColor colorIndex) { }

	[ThreadSafe]
	internal static Void* CreateCounterValue__Unmanaged(out IntPtr counterPtr, Byte* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions) { }

	[ThreadSafe]
	public static IntPtr CreateMarker(string name, ushort categoryId, MarkerFlags flags, int metadataCount) { }

	[ThreadSafe]
	internal static IntPtr CreateMarker__Unmanaged(Byte* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount) { }

	[ThreadSafe]
	public static void EndSample(IntPtr markerPtr) { }

	[ThreadSafe]
	public static ProfilerCategoryDescription GetCategoryDescription(ushort categoryId) { }

	private static void GetCategoryDescription_Injected(ushort categoryId, out ProfilerCategoryDescription ret) { }

	[ThreadSafe]
	internal static void SetMarkerMetadata__Unmanaged(IntPtr markerPtr, int index, Byte* name, int nameLen, byte type, byte unit) { }

	internal static string Utf8ToString(Byte* chars, int charsLen) { }

}

