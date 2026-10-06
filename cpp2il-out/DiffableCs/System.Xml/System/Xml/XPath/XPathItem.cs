namespace System.Xml.XPath;

public abstract class XPathItem
{

	public abstract object TypedValue
	{
		 get { } //Length: 0
	}

	public abstract string Value
	{
		 get { } //Length: 0
	}

	public abstract bool ValueAsBoolean
	{
		 get { } //Length: 0
	}

	public abstract DateTime ValueAsDateTime
	{
		 get { } //Length: 0
	}

	public abstract double ValueAsDouble
	{
		 get { } //Length: 0
	}

	public abstract int ValueAsInt
	{
		 get { } //Length: 0
	}

	public abstract long ValueAsLong
	{
		 get { } //Length: 0
	}

	public abstract Type ValueType
	{
		 get { } //Length: 0
	}

	public abstract XmlSchemaType XmlType
	{
		 get { } //Length: 0
	}

	protected XPathItem() { }

	public abstract object get_TypedValue() { }

	public abstract string get_Value() { }

	public abstract bool get_ValueAsBoolean() { }

	public abstract DateTime get_ValueAsDateTime() { }

	public abstract double get_ValueAsDouble() { }

	public abstract int get_ValueAsInt() { }

	public abstract long get_ValueAsLong() { }

	public abstract Type get_ValueType() { }

	public abstract XmlSchemaType get_XmlType() { }

	public override object ValueAs(Type returnType) { }

	public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

}

