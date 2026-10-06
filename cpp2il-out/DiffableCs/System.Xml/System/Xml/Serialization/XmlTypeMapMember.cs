namespace System.Xml.Serialization;

internal class XmlTypeMapMember
{
	private string _name; //Field offset: 0x10
	private int _index; //Field offset: 0x18
	private int _globalIndex; //Field offset: 0x1C
	private int _specifiedGlobalIndex; //Field offset: 0x20
	private TypeData _typeData; //Field offset: 0x28
	private MemberInfo _member; //Field offset: 0x30
	private MemberInfo _specifiedMember; //Field offset: 0x38
	private MethodInfo _shouldSerialize; //Field offset: 0x40
	private object _defaultValue; //Field offset: 0x48
	private int _flags; //Field offset: 0x50

	public object DefaultValue
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public int GlobalIndex
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int Index
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool IsOptionalValueType
	{
		 get { } //Length: 8
		 set { } //Length: 43
	}

	public bool IsReturnValue
	{
		 get { } //Length: 8
		 set { } //Length: 43
	}

	public string Name
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public TypeData TypeData
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public XmlTypeMapMember() { }

	public void CheckOptionalValueType(Type type) { }

	public object get_DefaultValue() { }

	public int get_GlobalIndex() { }

	public int get_Index() { }

	public bool get_IsOptionalValueType() { }

	public bool get_IsReturnValue() { }

	public string get_Name() { }

	public TypeData get_TypeData() { }

	public object GetValue(object ob) { }

	public static object GetValue(object ob, string name) { }

	public bool GetValueSpecified(object ob) { }

	private void InitMember(Type type) { }

	public bool IsReadOnly(Type type) { }

	public void set_DefaultValue(object value) { }

	public void set_GlobalIndex(int value) { }

	public void set_Index(int value) { }

	public void set_IsOptionalValueType(bool value) { }

	public void set_IsReturnValue(bool value) { }

	public void set_Name(string value) { }

	public void set_TypeData(TypeData value) { }

	public static void SetValue(object ob, string name, object value) { }

	public void SetValue(object ob, object value) { }

	public void SetValueSpecified(object ob, bool value) { }

}

