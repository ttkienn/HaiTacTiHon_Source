namespace System.Xml;

internal interface IDtdDefaultAttributeInfo : IDtdAttributeInfo
{

	public string DefaultValueExpanded
	{
		 get { } //Length: 0
	}

	public object DefaultValueTyped
	{
		 get { } //Length: 0
	}

	public int ValueLineNumber
	{
		 get { } //Length: 0
	}

	public int ValueLinePosition
	{
		 get { } //Length: 0
	}

	public string get_DefaultValueExpanded() { }

	public object get_DefaultValueTyped() { }

	public int get_ValueLineNumber() { }

	public int get_ValueLinePosition() { }

}

