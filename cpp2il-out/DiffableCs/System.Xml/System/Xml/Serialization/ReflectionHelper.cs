namespace System.Xml.Serialization;

internal class ReflectionHelper
{
	private static readonly ParameterModifier[] empty_modifiers; //Field offset: 0x0
	private Hashtable _clrTypes; //Field offset: 0x10
	private Hashtable _schemaTypes; //Field offset: 0x18

	private static ReflectionHelper() { }

	public ReflectionHelper() { }

	public static void CheckSerializableType(Type type, bool allowPrivateConstructors) { }

	public XmlTypeMapping GetRegisteredClrType(Type type, string ns) { }

	public XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns) { }

	public void RegisterClrType(XmlTypeMapping map, Type type, string ns) { }

	public void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns) { }

}

