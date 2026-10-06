namespace Unity.Properties;

internal interface IMemberInfo
{

	public bool IsReadOnly
	{
		 get { } //Length: 0
	}

	public string Name
	{
		 get { } //Length: 0
	}

	public Type ValueType
	{
		 get { } //Length: 0
	}

	public bool get_IsReadOnly() { }

	public string get_Name() { }

	public Type get_ValueType() { }

	public IEnumerable<Attribute> GetCustomAttributes() { }

}

