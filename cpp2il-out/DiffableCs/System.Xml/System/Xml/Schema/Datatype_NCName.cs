namespace System.Xml.Schema;

internal class Datatype_NCName : Datatype_Name
{

	public virtual XmlTypeCode TypeCode
	{
		 get { } //Length: 6
	}

	public Datatype_NCName() { }

	public virtual XmlTypeCode get_TypeCode() { }

	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

