namespace UnityEngine.TextCore.LowLevel;

[UsedByNativeCode]
internal struct MultipleSubstitutionRecord
{
	[NativeName("targetGlyphID")]
	[SerializeField]
	private uint m_TargetGlyphID; //Field offset: 0x0
	[NativeName("substituteGlyphIDs")]
	[SerializeField]
	private UInt32[] m_SubstituteGlyphIDs; //Field offset: 0x8

}

