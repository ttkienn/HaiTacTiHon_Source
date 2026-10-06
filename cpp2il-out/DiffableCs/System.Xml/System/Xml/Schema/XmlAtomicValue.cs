namespace System.Xml.Schema;

public sealed class XmlAtomicValue : XPathItem, ICloneable
{
	private class NamespacePrefixForQName : IXmlNamespaceResolver
	{
		public string prefix; //Field offset: 0x10
		public string ns; //Field offset: 0x18

		public NamespacePrefixForQName(string prefix, string ns) { }

		public override IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

		public override string LookupNamespace(string prefix) { }

		public override string LookupPrefix(string namespaceName) { }

	}

	private struct Union
	{
		public bool boolVal; //Field offset: 0x0
		public double dblVal; //Field offset: 0x0
		public long i64Val; //Field offset: 0x0
		public int i32Val; //Field offset: 0x0
		public DateTime dtVal; //Field offset: 0x0

	}

	private XmlSchemaType xmlType; //Field offset: 0x10
	private object objVal; //Field offset: 0x18
	private TypeCode clrType; //Field offset: 0x20
	private Union unionVal; //Field offset: 0x28
	private NamespacePrefixForQName nsPrefix; //Field offset: 0x30

	public virtual object TypedValue
	{
		 get { } //Length: 517
	}

	public virtual string Value
	{
		 get { } //Length: 305
	}

	public virtual bool ValueAsBoolean
	{
		 get { } //Length: 269
	}

	public virtual DateTime ValueAsDateTime
	{
		 get { } //Length: 269
	}

	public virtual double ValueAsDouble
	{
		 get { } //Length: 269
	}

	public virtual int ValueAsInt
	{
		 get { } //Length: 269
	}

	public virtual long ValueAsLong
	{
		 get { } //Length: 269
	}

	public virtual Type ValueType
	{
		 get { } //Length: 51
	}

	public virtual XmlSchemaType XmlType
	{
		 get { } //Length: 5
	}

	internal XmlAtomicValue(XmlSchemaType xmlType, bool value) { }

	internal XmlAtomicValue(XmlSchemaType xmlType, object value) { }

	internal XmlAtomicValue(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver) { }

	internal XmlAtomicValue(XmlSchemaType xmlType, string value) { }

	internal XmlAtomicValue(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver) { }

	internal XmlAtomicValue(XmlSchemaType xmlType, int value) { }

	internal XmlAtomicValue(XmlSchemaType xmlType, double value) { }

	internal XmlAtomicValue(XmlSchemaType xmlType, DateTime value) { }

	internal XmlAtomicValue(XmlSchemaType xmlType, long value) { }

	public virtual object get_TypedValue() { }

	public virtual string get_Value() { }

	public virtual bool get_ValueAsBoolean() { }

	public virtual DateTime get_ValueAsDateTime() { }

	public virtual double get_ValueAsDouble() { }

	public virtual int get_ValueAsInt() { }

	public virtual long get_ValueAsLong() { }

	public virtual Type get_ValueType() { }

	public virtual XmlSchemaType get_XmlType() { }

	private string GetPrefixFromQName(string value) { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	public virtual object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

}

