namespace UnityEngine.UIElements;

public class MeshGenerationContext
{
	[Flags]
	public enum MeshFlags
	{
		None = 0,
		UVisDisplacement = 1,
		SkipDynamicAtlas = 2,
	}

	private static readonly ProfilerMarker s_AllocateMarker; //Field offset: 0x0
	private static readonly ProfilerMarker s_DrawVectorImageMarker; //Field offset: 0x8
	private Painter2D m_Painter2D; //Field offset: 0x10
	internal IStylePainter painter; //Field offset: 0x18

	internal bool hasPainter2D
	{
		internal get { } //Length: 9
	}

	public Painter2D painter2D
	{
		 get { } //Length: 231
	}

	private static MeshGenerationContext() { }

	internal MeshGenerationContext(IStylePainter painter) { }

	internal bool get_hasPainter2D() { }

	public Painter2D get_painter2D() { }

}

