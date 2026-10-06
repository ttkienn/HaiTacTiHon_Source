namespace UnityEngine.TextCore.LowLevel;

[UsedByNativeCode]
public struct GlyphAdjustmentRecord : IEquatable<GlyphAdjustmentRecord>
{
	[NativeName("glyphIndex")]
	[SerializeField]
	private uint m_GlyphIndex; //Field offset: 0x0
	[NativeName("glyphValueRecord")]
	[SerializeField]
	private GlyphValueRecord m_GlyphValueRecord; //Field offset: 0x4

	public uint glyphIndex
	{
		 get { } //Length: 5
	}

	public GlyphValueRecord glyphValueRecord
	{
		 get { } //Length: 11
	}

	[ExcludeFromDocs]
	public virtual bool Equals(object obj) { }

	[ExcludeFromDocs]
	public override bool Equals(GlyphAdjustmentRecord other) { }

	public uint get_glyphIndex() { }

	public GlyphValueRecord get_glyphValueRecord() { }

	[ExcludeFromDocs]
	public virtual int GetHashCode() { }

}

