namespace UnityEngine.TextCore.LowLevel;

[UsedByNativeCode]
internal struct MarkToBaseAdjustmentRecord
{
	[NativeName("baseGlyphID")]
	[SerializeField]
	private uint m_BaseGlyphID; //Field offset: 0x0
	[NativeName("baseAnchor")]
	[SerializeField]
	private GlyphAnchorPoint m_BaseGlyphAnchorPoint; //Field offset: 0x4
	[NativeName("markGlyphID")]
	[SerializeField]
	private uint m_MarkGlyphID; //Field offset: 0xC
	[NativeName("markPositionAdjustment")]
	[SerializeField]
	private MarkPositionAdjustment m_MarkPositionAdjustment; //Field offset: 0x10

	public GlyphAnchorPoint baseGlyphAnchorPoint
	{
		 get { } //Length: 19
	}

	public uint baseGlyphID
	{
		 get { } //Length: 5
	}

	public uint markGlyphID
	{
		 get { } //Length: 6
	}

	public MarkPositionAdjustment markPositionAdjustment
	{
		 get { } //Length: 105
	}

	public GlyphAnchorPoint get_baseGlyphAnchorPoint() { }

	public uint get_baseGlyphID() { }

	public uint get_markGlyphID() { }

	public MarkPositionAdjustment get_markPositionAdjustment() { }

}

