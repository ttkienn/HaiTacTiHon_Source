namespace System.Xml.Serialization;

internal class EnumMap : ObjectMap
{
	internal class EnumMapMember
	{
		private readonly string _xmlName; //Field offset: 0x10
		private readonly string _enumName; //Field offset: 0x18
		private readonly long _value; //Field offset: 0x20

		public string EnumName
		{
			 get { } //Length: 5
		}

		public long Value
		{
			 get { } //Length: 5
		}

		public string XmlName
		{
			 get { } //Length: 5
		}

		public EnumMapMember(string xmlName, string enumName, long value) { }

		public string get_EnumName() { }

		public long get_Value() { }

		public string get_XmlName() { }

	}

	private readonly EnumMapMember[] _members; //Field offset: 0x10
	private readonly bool _isFlags; //Field offset: 0x18
	private readonly String[] _enumNames; //Field offset: 0x20
	private readonly String[] _xmlNames; //Field offset: 0x28
	private readonly Int64[] _values; //Field offset: 0x30

	public String[] EnumNames
	{
		 get { } //Length: 5
	}

	public bool IsFlags
	{
		 get { } //Length: 5
	}

	public Int64[] Values
	{
		 get { } //Length: 5
	}

	public String[] XmlNames
	{
		 get { } //Length: 5
	}

	public EnumMap(EnumMapMember[] members, bool isFlags) { }

	public String[] get_EnumNames() { }

	public bool get_IsFlags() { }

	public Int64[] get_Values() { }

	public String[] get_XmlNames() { }

	public string GetEnumName(string typeName, string xmlName) { }

	public string GetXmlName(string typeName, object enumValue) { }

}

