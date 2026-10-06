namespace System.Xml.Serialization;

internal class TypeData
{
	private static String[] keywords; //Field offset: 0x0
	private Type type; //Field offset: 0x10
	private string elementName; //Field offset: 0x18
	private SchemaTypes sType; //Field offset: 0x20
	private Type listItemType; //Field offset: 0x28
	private string typeName; //Field offset: 0x30
	private string fullTypeName; //Field offset: 0x38
	private TypeData listItemTypeData; //Field offset: 0x40
	private TypeData mappedType; //Field offset: 0x48
	private XmlSchemaPatternFacet facet; //Field offset: 0x50
	private MethodInfo typeConvertor; //Field offset: 0x58
	private bool hasPublicConstructor; //Field offset: 0x60
	private bool nullableOverride; //Field offset: 0x61

	public string FullTypeName
	{
		 get { } //Length: 5
	}

	public bool HasPublicConstructor
	{
		 get { } //Length: 5
	}

	public bool IsComplexType
	{
		 get { } //Length: 42
	}

	public bool IsListType
	{
		 get { } //Length: 8
	}

	public bool IsNullable
	{
		 get { } //Length: 387
		 set { } //Length: 4
	}

	public bool IsValueType
	{
		 get { } //Length: 151
	}

	public bool IsXsdType
	{
		 get { } //Length: 9
	}

	public Type ListItemType
	{
		 get { } //Length: 2396
	}

	public TypeData ListItemTypeData
	{
		 get { } //Length: 247
	}

	public SchemaTypes SchemaType
	{
		 get { } //Length: 4
	}

	public Type Type
	{
		 get { } //Length: 5
	}

	public string TypeName
	{
		 get { } //Length: 5
	}

	public string XmlType
	{
		 get { } //Length: 5
	}

	private static TypeData() { }

	public TypeData(Type type, string elementName, bool isPrimitive) { }

	public TypeData(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet) { }

	internal void ConvertForAssignment(ref object value) { }

	private static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType) { }

	public string get_FullTypeName() { }

	public bool get_HasPublicConstructor() { }

	public bool get_IsComplexType() { }

	public bool get_IsListType() { }

	public bool get_IsNullable() { }

	public bool get_IsValueType() { }

	public bool get_IsXsdType() { }

	public Type get_ListItemType() { }

	public TypeData get_ListItemTypeData() { }

	public SchemaTypes get_SchemaType() { }

	public Type get_Type() { }

	public string get_TypeName() { }

	public string get_XmlType() { }

	internal static Type GetGenericListItemType(Type type) { }

	public static PropertyInfo GetIndexerProperty(Type collectionType) { }

	private void LookupTypeConvertor() { }

	public void set_IsNullable(bool value) { }

}

