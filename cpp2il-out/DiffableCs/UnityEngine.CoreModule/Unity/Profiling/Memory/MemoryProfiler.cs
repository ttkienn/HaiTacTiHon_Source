namespace Unity.Profiling.Memory;

[NativeHeader("Modules/Profiler/Runtime/MemorySnapshotManager.h")]
public static class MemoryProfiler
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<String, Boolean> m_SnapshotFinished; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<String, Boolean, DebugScreenCapture> m_SaveScreenshotToDisk; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<MemorySnapshotMetadata> CreatingMetadata; //Field offset: 0x10

	[RequiredByNativeCode]
	private static void FinalizeSnapshot(string path, bool result) { }

	[RequiredByNativeCode]
	private static Byte[] PrepareMetadata() { }

	[RequiredByNativeCode]
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }

	internal static int WriteIntToByteArray(Byte[] array, int offset, int value) { }

	internal static int WriteStringToByteArray(Byte[] array, int offset, string value) { }

}

