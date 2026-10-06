namespace UnityEngine.TextCore.LowLevel;

[UsedByNativeCode]
public struct GlyphValueRecord : IEquatable<GlyphValueRecord>
{
	[NativeName("xPlacement")]
	[SerializeField]
	private float m_XPlacement; //Field offset: 0x0
	[NativeName("yPlacement")]
	[SerializeField]
	private float m_YPlacement; //Field offset: 0x4
	[NativeName("xAdvance")]
	[SerializeField]
	private float m_XAdvance; //Field offset: 0x8
	[NativeName("yAdvance")]
	[SerializeField]
	private float m_YAdvance; //Field offset: 0xC

	public float xAdvance
	{
		 get { } //Length: 8
	}

	public float xPlacement
	{
		 get { } //Length: 7
		 set { } //Length: 5
	}

	public float yAdvance
	{
		 get { } //Length: 8
	}

	public float yPlacement
	{
		 get { } //Length: 8
		 set { } //Length: 6
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(GlyphValueRecord other) { }

	public float get_xAdvance() { }

	public float get_xPlacement() { }

	public float get_yAdvance() { }

	public float get_yPlacement() { }

	public virtual int GetHashCode() { }

	public static GlyphValueRecord op_Addition(GlyphValueRecord a, GlyphValueRecord b) { }

	public void set_xPlacement(float value) { }

	public void set_yPlacement(float value) { }

}

