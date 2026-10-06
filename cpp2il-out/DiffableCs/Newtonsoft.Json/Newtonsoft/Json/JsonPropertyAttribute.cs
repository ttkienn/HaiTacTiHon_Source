namespace Newtonsoft.Json;

[AttributeUsage(2432, AllowMultiple = False)]
[Nullable(0)]
[NullableContext(2)]
public sealed class JsonPropertyAttribute : Attribute
{
	internal Nullable<NullValueHandling> _nullValueHandling; //Field offset: 0x10
	internal Nullable<DefaultValueHandling> _defaultValueHandling; //Field offset: 0x18
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; //Field offset: 0x20
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; //Field offset: 0x28
	internal Nullable<TypeNameHandling> _typeNameHandling; //Field offset: 0x30
	internal Nullable<Boolean> _isReference; //Field offset: 0x38
	internal Nullable<Int32> _order; //Field offset: 0x3C
	internal Nullable<Required> _required; //Field offset: 0x44
	internal Nullable<Boolean> _itemIsReference; //Field offset: 0x4C
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; //Field offset: 0x50
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; //Field offset: 0x58
	[CompilerGenerated]
	private Type <ItemConverterType>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Object[] <ItemConverterParameters>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private Type <NamingStrategyType>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Object[] <NamingStrategyParameters>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private string <PropertyName>k__BackingField; //Field offset: 0x80

	public DefaultValueHandling DefaultValueHandling
	{
		 get { } //Length: 55
		 set { } //Length: 91
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

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public Object[] NamingStrategyParameters
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public Type NamingStrategyType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public NullValueHandling NullValueHandling
	{
		 get { } //Length: 55
		 set { } //Length: 91
	}

	public ObjectCreationHandling ObjectCreationHandling
	{
		 get { } //Length: 55
		 set { } //Length: 91
	}

	public int Order
	{
		 get { } //Length: 55
		 set { } //Length: 91
	}

	public string PropertyName
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public ReferenceLoopHandling ReferenceLoopHandling
	{
		 get { } //Length: 55
		 set { } //Length: 91
	}

	public Required Required
	{
		 get { } //Length: 55
		 set { } //Length: 91
	}

	public TypeNameHandling TypeNameHandling
	{
		 get { } //Length: 55
		 set { } //Length: 91
	}

	[NullableContext(1)]
	public JsonPropertyAttribute(string propertyName) { }

	public JsonPropertyAttribute() { }

	public DefaultValueHandling get_DefaultValueHandling() { }

	public bool get_IsReference() { }

	[CompilerGenerated]
	public Object[] get_ItemConverterParameters() { }

	[CompilerGenerated]
	public Type get_ItemConverterType() { }

	public bool get_ItemIsReference() { }

	public ReferenceLoopHandling get_ItemReferenceLoopHandling() { }

	public TypeNameHandling get_ItemTypeNameHandling() { }

	[CompilerGenerated]
	public Object[] get_NamingStrategyParameters() { }

	[CompilerGenerated]
	public Type get_NamingStrategyType() { }

	public NullValueHandling get_NullValueHandling() { }

	public ObjectCreationHandling get_ObjectCreationHandling() { }

	public int get_Order() { }

	[CompilerGenerated]
	public string get_PropertyName() { }

	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	public Required get_Required() { }

	public TypeNameHandling get_TypeNameHandling() { }

	public void set_DefaultValueHandling(DefaultValueHandling value) { }

	public void set_IsReference(bool value) { }

	[CompilerGenerated]
	public void set_ItemConverterParameters(Object[] value) { }

	[CompilerGenerated]
	public void set_ItemConverterType(Type value) { }

	public void set_ItemIsReference(bool value) { }

	public void set_ItemReferenceLoopHandling(ReferenceLoopHandling value) { }

	public void set_ItemTypeNameHandling(TypeNameHandling value) { }

	[CompilerGenerated]
	public void set_NamingStrategyParameters(Object[] value) { }

	[CompilerGenerated]
	public void set_NamingStrategyType(Type value) { }

	public void set_NullValueHandling(NullValueHandling value) { }

	public void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	public void set_Order(int value) { }

	[CompilerGenerated]
	public void set_PropertyName(string value) { }

	public void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	public void set_Required(Required value) { }

	public void set_TypeNameHandling(TypeNameHandling value) { }

}

