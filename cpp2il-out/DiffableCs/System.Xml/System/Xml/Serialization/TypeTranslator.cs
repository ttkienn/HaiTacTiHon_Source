namespace System.Xml.Serialization;

internal class TypeTranslator
{
	private static Hashtable nameCache; //Field offset: 0x0
	private static Hashtable primitiveTypes; //Field offset: 0x8
	private static Hashtable primitiveArrayTypes; //Field offset: 0x10
	private static Hashtable nullableTypes; //Field offset: 0x18

	private static TypeTranslator() { }

	public static TypeData FindPrimitiveTypeData(string typeName) { }

	public static string GetArrayName(string elemName) { }

	public static TypeData GetPrimitiveTypeData(string typeName) { }

	public static TypeData GetPrimitiveTypeData(string typeName, bool nullable) { }

	public static TypeData GetTypeData(Type type) { }

	public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType = false) { }

	public static void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions) { }

}

