namespace UnityEngine.TextCore;

[UsedByNativeCode]
public struct GlyphRect : IEquatable<GlyphRect>
{
	private static readonly GlyphRect s_ZeroGlyphRect; //Field offset: 0x0
	[NativeName("x")]
	[SerializeField]
	private int m_X; //Field offset: 0x0
	[NativeName("y")]
	[SerializeField]
	private int m_Y; //Field offset: 0x4
	[NativeName("width")]
	[SerializeField]
	private int m_Width; //Field offset: 0x8
	[NativeName("height")]
	[SerializeField]
	private int m_Height; //Field offset: 0xC

	public int height
	{
		 get { } //Length: 6
	}

	public int width
	{
		 get { } //Length: 6
	}

	public int x
	{
		 get { } //Length: 5
	}

	public int y
	{
		 get { } //Length: 6
	}

	public static GlyphRect zero
	{
		 get { } //Length: 96
	}

	private static GlyphRect() { }

	public GlyphRect(int x, int y, int width, int height) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(GlyphRect other) { }

	public int get_height() { }

	public int get_width() { }

	public int get_x() { }

	public int get_y() { }

	public static GlyphRect get_zero() { }

	public virtual int GetHashCode() { }

}

