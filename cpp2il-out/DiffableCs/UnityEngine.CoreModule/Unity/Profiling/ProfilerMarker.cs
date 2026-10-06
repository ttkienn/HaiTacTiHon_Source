namespace Unity.Profiling;

[IgnoredByDeepProfiler]
[UsedByNativeCode]
public struct ProfilerMarker
{
	[IgnoredByDeepProfiler]
	[UsedByNativeCode]
	internal struct AutoScope : IDisposable
	{
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr m_Ptr; //Field offset: 0x0

		internal AutoScope(IntPtr markerPtr) { }

		public override void Dispose() { }

	}

	[NativeDisableUnsafePtrRestriction]
	internal readonly IntPtr m_Ptr; //Field offset: 0x0

	public ProfilerMarker(string name) { }

	public ProfilerMarker(ProfilerCategory category, string name) { }

	[Pure]
	public AutoScope Auto() { }

}

