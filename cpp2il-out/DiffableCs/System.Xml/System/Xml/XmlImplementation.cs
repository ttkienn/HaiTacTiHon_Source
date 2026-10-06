namespace System.Xml;

public class XmlImplementation
{
	private XmlNameTable nameTable; //Field offset: 0x10

	internal XmlNameTable NameTable
	{
		internal get { } //Length: 5
	}

	public XmlImplementation() { }

	public XmlImplementation(XmlNameTable nt) { }

	public override XmlDocument CreateDocument() { }

	internal XmlNameTable get_NameTable() { }

}

