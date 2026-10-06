namespace UnityEngine.TextCore.Text;

internal struct LinkInfo
{
	public int hashCode; //Field offset: 0x0
	public int linkIdFirstCharacterIndex; //Field offset: 0x4
	public int linkIdLength; //Field offset: 0x8
	public int linkTextfirstCharacterIndex; //Field offset: 0xC
	public int linkTextLength; //Field offset: 0x10
	internal Char[] linkId; //Field offset: 0x18
	private string m_LinkIdString; //Field offset: 0x20
	private string m_LinkTextString; //Field offset: 0x28

	public string GetLinkId() { }

	public string GetLinkText(TextInfo textInfo) { }

	internal void SetLinkId(Char[] text, int startIndex, int length) { }

}

