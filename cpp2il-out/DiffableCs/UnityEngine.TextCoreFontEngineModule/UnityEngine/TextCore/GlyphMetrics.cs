namespace UnityEngine.TextCore;

[UsedByNativeCode]
public struct GlyphMetrics : IEquatable<GlyphMetrics>
{
	[NativeName("width")]
	[SerializeField]
	private float m_Width; //Field offset: 0x0
	[NativeName("height")]
	[SerializeField]
	private float m_Height; //Field offset: 0x4
	[NativeName("horizontalBearingX")]
	[SerializeField]
	private float m_HorizontalBearingX; //Field offset: 0x8
	[NativeName("horizontalBearingY")]
	[SerializeField]
	private float m_HorizontalBearingY; //Field offset: 0xC
	[NativeName("horizontalAdvance")]
	[SerializeField]
	private float m_HorizontalAdvance; //Field offset: 0x10

	public float height
	{
		 get { } //Length: 8
	}

	public float horizontalAdvance
	{
		 get { } //Length: 8
	}

	public float horizontalBearingX
	{
		 get { } //Length: 8
	}

	public float horizontalBearingY
	{
		 get { } //Length: 8
	}

	public float width
	{
		 get { } //Length: 7
	}

	public GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(GlyphMetrics other) { }

	public float get_height() { }

	public float get_horizontalAdvance() { }

	public float get_horizontalBearingX() { }

	public float get_horizontalBearingY() { }

	public float get_width() { }

	public virtual int GetHashCode() { }

}

