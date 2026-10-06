namespace UnityEngine.TextCore.LowLevel;

[UsedByNativeCode]
internal struct GlyphMarshallingStruct
{
	public uint index; //Field offset: 0x0
	public GlyphMetrics metrics; //Field offset: 0x4
	public GlyphRect glyphRect; //Field offset: 0x18
	public float scale; //Field offset: 0x28
	public int atlasIndex; //Field offset: 0x2C
	public GlyphClassDefinitionType classDefinitionType; //Field offset: 0x30

}

