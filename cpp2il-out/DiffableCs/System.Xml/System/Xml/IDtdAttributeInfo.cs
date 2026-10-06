namespace System.Xml;

internal interface IDtdAttributeInfo
{

	public bool IsDeclaredInExternal
	{
		 get { } //Length: 0
	}

	public bool IsNonCDataType
	{
		 get { } //Length: 0
	}

	public bool IsXmlAttribute
	{
		 get { } //Length: 0
	}

	public int LineNumber
	{
		 get { } //Length: 0
	}

	public int LinePosition
	{
		 get { } //Length: 0
	}

	public string LocalName
	{
		 get { } //Length: 0
	}

	public string Prefix
	{
		 get { } //Length: 0
	}

	public bool get_IsDeclaredInExternal() { }

	public bool get_IsNonCDataType() { }

	public bool get_IsXmlAttribute() { }

	public int get_LineNumber() { }

	public int get_LinePosition() { }

	public string get_LocalName() { }

	public string get_Prefix() { }

}

