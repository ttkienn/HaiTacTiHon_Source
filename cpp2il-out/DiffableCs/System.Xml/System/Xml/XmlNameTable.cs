namespace System.Xml;

public abstract class XmlNameTable
{

	protected XmlNameTable() { }

	public abstract string Add(Char[] array, int offset, int length) { }

	public abstract string Add(string array) { }

	public abstract string Get(string array) { }

}

