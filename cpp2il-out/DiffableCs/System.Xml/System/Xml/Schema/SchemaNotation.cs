namespace System.Xml.Schema;

internal sealed class SchemaNotation
{
	private XmlQualifiedName name; //Field offset: 0x10
	private string systemLiteral; //Field offset: 0x18
	private string pubid; //Field offset: 0x20

	internal XmlQualifiedName Name
	{
		internal get { } //Length: 5
	}

	internal string Pubid
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	internal string SystemLiteral
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	internal SchemaNotation(XmlQualifiedName name) { }

	internal XmlQualifiedName get_Name() { }

	internal string get_Pubid() { }

	internal string get_SystemLiteral() { }

	internal void set_Pubid(string value) { }

	internal void set_SystemLiteral(string value) { }

}

