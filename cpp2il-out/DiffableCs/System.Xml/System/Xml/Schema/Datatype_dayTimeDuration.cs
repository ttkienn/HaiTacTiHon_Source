namespace System.Xml.Schema;

internal class Datatype_dayTimeDuration : Datatype_duration
{

	public virtual XmlTypeCode TypeCode
	{
		 get { } //Length: 6
	}

	public Datatype_dayTimeDuration() { }

	public virtual XmlTypeCode get_TypeCode() { }

	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

