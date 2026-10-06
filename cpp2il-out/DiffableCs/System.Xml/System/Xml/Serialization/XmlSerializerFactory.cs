namespace System.Xml.Serialization;

public class XmlSerializerFactory
{
	private static Hashtable serializersBySource; //Field offset: 0x0

	private static XmlSerializerFactory() { }

	public XmlSerializerFactory() { }

	public XmlSerializer CreateSerializer(Type type) { }

	public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root) { }

	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

}

