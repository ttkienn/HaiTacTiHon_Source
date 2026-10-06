namespace System.Xml;

internal interface IDtdEntityInfo
{

	public string BaseUriString
	{
		 get { } //Length: 0
	}

	public string DeclaredUriString
	{
		 get { } //Length: 0
	}

	public bool IsDeclaredInExternal
	{
		 get { } //Length: 0
	}

	public bool IsExternal
	{
		 get { } //Length: 0
	}

	public bool IsParameterEntity
	{
		 get { } //Length: 0
	}

	public bool IsUnparsedEntity
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

	public string Name
	{
		 get { } //Length: 0
	}

	public string PublicId
	{
		 get { } //Length: 0
	}

	public string SystemId
	{
		 get { } //Length: 0
	}

	public string Text
	{
		 get { } //Length: 0
	}

	public string get_BaseUriString() { }

	public string get_DeclaredUriString() { }

	public bool get_IsDeclaredInExternal() { }

	public bool get_IsExternal() { }

	public bool get_IsParameterEntity() { }

	public bool get_IsUnparsedEntity() { }

	public int get_LineNumber() { }

	public int get_LinePosition() { }

	public string get_Name() { }

	public string get_PublicId() { }

	public string get_SystemId() { }

	public string get_Text() { }

}

