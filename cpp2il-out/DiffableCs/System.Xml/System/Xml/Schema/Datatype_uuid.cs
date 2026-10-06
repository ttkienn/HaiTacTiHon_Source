namespace System.Xml.Schema;

internal class Datatype_uuid : Datatype_anySimpleType
{
	private static readonly Type atomicValueType; //Field offset: 0x0
	private static readonly Type listValueType; //Field offset: 0x8

	internal virtual Type ListValueType
	{
		internal get { } //Length: 79
	}

	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		internal get { } //Length: 3
	}

	public virtual Type ValueType
	{
		 get { } //Length: 78
	}

	private static Datatype_uuid() { }

	public Datatype_uuid() { }

	internal virtual int Compare(object value1, object value2) { }

	internal virtual Type get_ListValueType() { }

	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	public virtual Type get_ValueType() { }

	public virtual object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

