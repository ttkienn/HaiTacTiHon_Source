namespace System.Xml;

internal class XmlTextEncoder
{
	private TextWriter textWriter; //Field offset: 0x10
	private bool inAttribute; //Field offset: 0x18
	private char quoteChar; //Field offset: 0x1A
	private StringBuilder attrValue; //Field offset: 0x20
	private bool cacheAttrValue; //Field offset: 0x28
	private XmlCharType xmlCharType; //Field offset: 0x30

	internal string AttributeValue
	{
		internal get { } //Length: 105
	}

	internal char QuoteChar
	{
		internal set { } //Length: 5
	}

	internal XmlTextEncoder(TextWriter textWriter) { }

	internal void EndAttribute() { }

	internal string get_AttributeValue() { }

	internal void set_QuoteChar(char value) { }

	internal void StartAttribute(bool cacheAttrValue) { }

	internal void Write(Char[] array, int offset, int count) { }

	internal void Write(string text) { }

	internal void WriteCharEntity(char ch) { }

	private void WriteCharEntityImpl(string strVal) { }

	private void WriteCharEntityImpl(char ch) { }

	internal void WriteEntityRef(string name) { }

	private void WriteEntityRefImpl(string name) { }

	internal void WriteRaw(Char[] array, int offset, int count) { }

	internal void WriteRawWithSurrogateChecking(string text) { }

	private void WriteStringFragment(string str, int offset, int count, Char[] helperBuffer) { }

	internal void WriteSurrogateChar(char lowChar, char highChar) { }

	internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

}

