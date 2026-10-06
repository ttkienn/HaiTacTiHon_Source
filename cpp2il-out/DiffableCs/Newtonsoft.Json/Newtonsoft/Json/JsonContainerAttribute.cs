namespace Newtonsoft.Json;

[AttributeUsage(1028, AllowMultiple = False)]
[Nullable(0)]
[NullableContext(2)]
public abstract class JsonContainerAttribute : Attribute
{
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Title>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Description>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Type <ItemConverterType>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Object[] <ItemConverterParameters>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private NamingStrategy <NamingStrategyInstance>k__BackingField; //Field offset: 0x38
	internal Nullable<Boolean> _isReference; //Field offset: 0x40
	internal Nullable<Boolean> _itemIsReference; //Field offset: 0x42
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; //Field offset: 0x44
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; //Field offset: 0x4C
	private Type _namingStrategyType; //Field offset: 0x58
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Object[] _namingStrategyParameters; //Field offset: 0x60

	public string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public string Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public bool IsReference
	{
		 get { } //Length: 57
		 set { } //Length: 91
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public Object[] ItemConverterParameters
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public Type ItemConverterType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public bool ItemIsReference
	{
		 get { } //Length: 57
		 set { } //Length: 91
	}

	public ReferenceLoopHandling ItemReferenceLoopHandling
	{
		 get { } //Length: 55
		 set { } //Length: 91
	}

	public TypeNameHandling ItemTypeNameHandling
	{
		 get { } //Length: 55
		 set { } //Length: 91
	}

	internal NamingStrategy NamingStrategyInstance
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public Object[] NamingStrategyParameters
	{
		 get { } //Length: 5
		 set { } //Length: 46
	}

	public Type NamingStrategyType
	{
		 get { } //Length: 5
		 set { } //Length: 46
	}

	public string Title
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	[NullableContext(1)]
	protected JsonContainerAttribute(string id) { }

	protected JsonContainerAttribute() { }

	[CompilerGenerated]
	public string get_Description() { }

	[CompilerGenerated]
	public string get_Id() { }

	public bool get_IsReference() { }

	[CompilerGenerated]
	public Object[] get_ItemConverterParameters() { }

	[CompilerGenerated]
	public Type get_ItemConverterType() { }

	public bool get_ItemIsReference() { }

	public ReferenceLoopHandling get_ItemReferenceLoopHandling() { }

	public TypeNameHandling get_ItemTypeNameHandling() { }

	[CompilerGenerated]
	internal NamingStrategy get_NamingStrategyInstance() { }

	public Object[] get_NamingStrategyParameters() { }

	public Type get_NamingStrategyType() { }

	[CompilerGenerated]
	public string get_Title() { }

	[CompilerGenerated]
	public void set_Description(string value) { }

	[CompilerGenerated]
	public void set_Id(string value) { }

	public void set_IsReference(bool value) { }

	[CompilerGenerated]
	public void set_ItemConverterParameters(Object[] value) { }

	[CompilerGenerated]
	public void set_ItemConverterType(Type value) { }

	public void set_ItemIsReference(bool value) { }

	public void set_ItemReferenceLoopHandling(ReferenceLoopHandling value) { }

	public void set_ItemTypeNameHandling(TypeNameHandling value) { }

	[CompilerGenerated]
	internal void set_NamingStrategyInstance(NamingStrategy value) { }

	public void set_NamingStrategyParameters(Object[] value) { }

	public void set_NamingStrategyType(Type value) { }

	[CompilerGenerated]
	public void set_Title(string value) { }

}

