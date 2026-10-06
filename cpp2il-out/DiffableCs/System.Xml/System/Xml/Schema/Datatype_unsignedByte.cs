namespace System.Xml.Schema;

internal class Datatype_unsignedByte : Datatype_unsignedShort
{
	private static readonly Type atomicValueType; //Field offset: 0x0
	private static readonly Type listValueType; //Field offset: 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

	internal virtual FacetsChecker FacetsChecker
	{
		internal get { } //Length: 79
	}

	internal virtual Type ListValueType
	{
		internal get { } //Length: 79
	}

	public virtual XmlTypeCode TypeCode
	{
		 get { } //Length: 6
	}

	public virtual Type ValueType
	{
		 get { } //Length: 78
	}

	private static Datatype_unsignedByte() { }

	public Datatype_unsignedByte() { }

	internal virtual int Compare(object value1, object value2) { }

	internal virtual FacetsChecker get_FacetsChecker() { }

	internal virtual Type get_ListValueType() { }

	public virtual XmlTypeCode get_TypeCode() { }

	public virtual Type get_ValueType() { }

	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

