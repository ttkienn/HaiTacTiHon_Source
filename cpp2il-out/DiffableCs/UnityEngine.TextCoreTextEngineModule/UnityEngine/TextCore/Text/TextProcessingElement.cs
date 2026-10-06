namespace UnityEngine.TextCore.Text;

[DebuggerDisplay("Unicode ({unicode})  '{(char)unicode}'")]
internal struct TextProcessingElement
{
	public TextProcessingElementType elementType; //Field offset: 0x0
	public uint unicode; //Field offset: 0x4
	public int stringIndex; //Field offset: 0x8
	public int length; //Field offset: 0xC

}

