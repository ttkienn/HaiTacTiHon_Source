namespace UnityEngine.TextCore.LowLevel;

[DebuggerDisplay("First glyphIndex = {m_FirstAdjustmentRecord.m_GlyphIndex},  Second glyphIndex = {m_SecondAdjustmentRecord.m_GlyphIndex}")]
[UsedByNativeCode]
public struct GlyphPairAdjustmentRecord : IEquatable<GlyphPairAdjustmentRecord>
{
	[NativeName("firstAdjustmentRecord")]
	[SerializeField]
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; //Field offset: 0x0
	[NativeName("secondAdjustmentRecord")]
	[SerializeField]
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; //Field offset: 0x14
	[SerializeField]
	private FontFeatureLookupFlags m_FeatureLookupFlags; //Field offset: 0x28

	public FontFeatureLookupFlags featureLookupFlags
	{
		 get { } //Length: 1817
	}

	public GlyphAdjustmentRecord firstAdjustmentRecord
	{
		 get { } //Length: 16
	}

	public GlyphAdjustmentRecord secondAdjustmentRecord
	{
		 get { } //Length: 17
	}

	[ExcludeFromDocs]
	public virtual bool Equals(object obj) { }

	[ExcludeFromDocs]
	public override bool Equals(GlyphPairAdjustmentRecord other) { }

	public FontFeatureLookupFlags get_featureLookupFlags() { }

	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	[ExcludeFromDocs]
	public virtual int GetHashCode() { }

}

