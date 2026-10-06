namespace UnityEngine.UIElements;

public class Painter2D : IDisposable
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static bool <isPainterActive>k__BackingField; //Field offset: 0x0
	private static float s_MaxArcRadius; //Field offset: 0x4
	private static readonly ProfilerMarker s_StrokeMarker; //Field offset: 0x8
	private static readonly ProfilerMarker s_FillMarker; //Field offset: 0x10
	private MeshGenerationContext m_Ctx; //Field offset: 0x10
	internal DetachedAllocator m_DetachedAllocator; //Field offset: 0x18
	internal SafeHandleAccess m_Handle; //Field offset: 0x20
	private bool m_Disposed; //Field offset: 0x28

	internal static bool isPainterActive
	{
		[CompilerGenerated]
		internal set { } //Length: 83
	}

	private static Painter2D() { }

	internal Painter2D(MeshGenerationContext ctx) { }

	public Painter2D() { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	internal void Reset() { }

	[CompilerGenerated]
	internal static void set_isPainterActive(bool value) { }

}

