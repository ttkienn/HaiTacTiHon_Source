namespace Mono.Xml;

internal class SmallXmlParserException : SystemException
{
	private int line; //Field offset: 0x90
	private int column; //Field offset: 0x94

	public SmallXmlParserException(string msg, int line, int column) { }

}

