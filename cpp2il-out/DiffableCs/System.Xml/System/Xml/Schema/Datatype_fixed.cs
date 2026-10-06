namespace System.Xml.Schema;

internal class Datatype_fixed : Datatype_decimal
{

	public Datatype_fixed() { }

	public virtual object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

