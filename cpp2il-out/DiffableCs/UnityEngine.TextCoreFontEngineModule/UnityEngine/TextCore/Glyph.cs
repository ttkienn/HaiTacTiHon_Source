namespace UnityEngine.TextCore;

[UsedByNativeCode]
public class Glyph
{
	[NativeName("index")]
	[SerializeField]
	private uint m_Index; //Field offset: 0x10
	[NativeName("metrics")]
	[SerializeField]
	private GlyphMetrics m_Metrics; //Field offset: 0x14
	[NativeName("glyphRect")]
	[SerializeField]
	private GlyphRect m_GlyphRect; //Field offset: 0x28
	[NativeName("scale")]
	[SerializeField]
	private float m_Scale; //Field offset: 0x38
	[NativeName("atlasIndex")]
	[SerializeField]
	private int m_AtlasIndex; //Field offset: 0x3C
	[NativeName("type")]
	[SerializeField]
	private GlyphClassDefinitionType m_ClassDefinitionType; //Field offset: 0x40

	public int atlasIndex
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public GlyphRect glyphRect
	{
		 get { } //Length: 11
	}

	public uint index
	{
		 get { } //Length: 6
	}

	public GlyphMetrics metrics
	{
		 get { } //Length: 17
	}

	public float scale
	{
		 get { } //Length: 8
	}

	public Glyph() { }

	internal Glyph(GlyphMarshallingStruct glyphStruct) { }

	public Glyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

	public int get_atlasIndex() { }

	public GlyphRect get_glyphRect() { }

	public uint get_index() { }

	public GlyphMetrics get_metrics() { }

	public float get_scale() { }

	public void set_atlasIndex(int value) { }

}

