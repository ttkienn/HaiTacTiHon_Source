namespace UnityEngine.TextCore.Text;

internal struct FontStyleStack
{
	public byte bold; //Field offset: 0x0
	public byte italic; //Field offset: 0x1
	public byte underline; //Field offset: 0x2
	public byte strikethrough; //Field offset: 0x3
	public byte highlight; //Field offset: 0x4
	public byte superscript; //Field offset: 0x5
	public byte subscript; //Field offset: 0x6
	public byte uppercase; //Field offset: 0x7
	public byte lowercase; //Field offset: 0x8
	public byte smallcaps; //Field offset: 0x9

	public byte Add(FontStyles style) { }

	public void Clear() { }

	public byte Remove(FontStyles style) { }

}

