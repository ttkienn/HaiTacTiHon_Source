namespace UnityEngine.TextCore.LowLevel;

[UsedByNativeCode]
internal struct LigatureSubstitutionRecord
{
	[NativeName("componentGlyphs")]
	[SerializeField]
	private UInt32[] m_ComponentGlyphIDs; //Field offset: 0x0
	[NativeName("ligatureGlyph")]
	[SerializeField]
	private uint m_LigatureGlyphID; //Field offset: 0x8

	public UInt32[] componentGlyphIDs
	{
		 get { } //Length: 6
	}

	public uint ligatureGlyphID
	{
		 get { } //Length: 6
	}

	public UInt32[] get_componentGlyphIDs() { }

	public uint get_ligatureGlyphID() { }

}

