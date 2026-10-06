namespace System.Xml.Schema;

internal class XsdSimpleValue
{
	private XmlSchemaSimpleType xmlType; //Field offset: 0x10
	private object typedValue; //Field offset: 0x18

	public object TypedValue
	{
		 get { } //Length: 5
	}

	public XmlSchemaSimpleType XmlType
	{
		 get { } //Length: 5
	}

	public XsdSimpleValue(XmlSchemaSimpleType st, object value) { }

	public object get_TypedValue() { }

	public XmlSchemaSimpleType get_XmlType() { }

}

