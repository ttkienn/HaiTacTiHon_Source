namespace System.Xml.Schema;

internal class TypedObject
{
	private class DecimalStruct
	{
		private bool isDecimal; //Field offset: 0x10
		private Decimal[] dvalue; //Field offset: 0x18

		public Decimal[] Dvalue
		{
			 get { } //Length: 5
		}

		public bool IsDecimal
		{
			 get { } //Length: 5
			 set { } //Length: 4
		}

		public DecimalStruct() { }

		public DecimalStruct(int dim) { }

		public Decimal[] get_Dvalue() { }

		public bool get_IsDecimal() { }

		public void set_IsDecimal(bool value) { }

	}

	private DecimalStruct dstruct; //Field offset: 0x10
	private object ovalue; //Field offset: 0x18
	private string svalue; //Field offset: 0x20
	private XmlSchemaDatatype xsdtype; //Field offset: 0x28
	private int dim; //Field offset: 0x30
	private bool isList; //Field offset: 0x34

	public int Dim
	{
		 get { } //Length: 4
	}

	public Decimal[] Dvalue
	{
		 get { } //Length: 27
	}

	public bool IsDecimal
	{
		 get { } //Length: 27
	}

	public bool IsList
	{
		 get { } //Length: 5
	}

	public XmlSchemaDatatype Type
	{
		 get { } //Length: 5
	}

	public object Value
	{
		 get { } //Length: 5
	}

	public TypedObject(object obj, string svalue, XmlSchemaDatatype xsdtype) { }

	public bool Equals(TypedObject other) { }

	public int get_Dim() { }

	public Decimal[] get_Dvalue() { }

	public bool get_IsDecimal() { }

	public bool get_IsList() { }

	public XmlSchemaDatatype get_Type() { }

	public object get_Value() { }

	private bool ListDValueEquals(TypedObject other) { }

	public void SetDecimal() { }

	public virtual string ToString() { }

}

