namespace UnityEngine.TextCore.LowLevel;

[DebuggerDisplay("{familyName} - {styleName}")]
[UsedByNativeCode]
internal struct FontReference
{
	public string familyName; //Field offset: 0x0
	public string styleName; //Field offset: 0x8
	public int faceIndex; //Field offset: 0x10
	public string filePath; //Field offset: 0x18

}

