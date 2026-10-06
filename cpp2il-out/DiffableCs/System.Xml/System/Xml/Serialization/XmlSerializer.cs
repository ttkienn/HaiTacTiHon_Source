namespace System.Xml.Serialization;

public class XmlSerializer
{
	public class SerializerData
	{
		public MethodInfo ReaderMethod; //Field offset: 0x10
		public Type WriterType; //Field offset: 0x18
		public MethodInfo WriterMethod; //Field offset: 0x20
		public XmlSerializerImplementation Implementation; //Field offset: 0x28

		public XmlSerializationWriter CreateWriter() { }

	}

	private static int generationThreshold; //Field offset: 0x0
	private static bool backgroundGeneration; //Field offset: 0x4
	private static bool deleteTempFiles; //Field offset: 0x5
	private static bool generatorFallback; //Field offset: 0x6
	private static Hashtable serializerTypes; //Field offset: 0x8
	private bool customSerializer; //Field offset: 0x10
	private XmlMapping typeMapping; //Field offset: 0x18
	private SerializerData serializerData; //Field offset: 0x20
	private UnreferencedObjectEventHandler onUnreferencedObject; //Field offset: 0x28
	private XmlAttributeEventHandler onUnknownAttribute; //Field offset: 0x30
	private XmlElementEventHandler onUnknownElement; //Field offset: 0x38
	private XmlNodeEventHandler onUnknownNode; //Field offset: 0x40

	internal XmlMapping Mapping
	{
		internal get { } //Length: 5
	}

	private static XmlSerializer() { }

	public XmlSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	protected override XmlSerializationReader CreateReader() { }

	private XmlSerializationReader CreateReader(XmlMapping typeMapping) { }

	private XmlSerializationWriter CreateWriter(XmlMapping typeMapping) { }

	protected override XmlSerializationWriter CreateWriter() { }

	public object Deserialize(TextReader textReader) { }

	public object Deserialize(XmlReader xmlReader) { }

	protected override object Deserialize(XmlSerializationReader reader) { }

	internal XmlMapping get_Mapping() { }

	internal override void OnUnknownAttribute(XmlAttributeEventArgs e) { }

	internal override void OnUnknownElement(XmlElementEventArgs e) { }

	internal override void OnUnknownNode(XmlNodeEventArgs e) { }

	internal override void OnUnreferencedObject(UnreferencedObjectEventArgs e) { }

	protected override void Serialize(object o, XmlSerializationWriter writer) { }

	public void Serialize(TextWriter textWriter, object o) { }

	public void Serialize(XmlWriter xmlWriter, object o) { }

	public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) { }

}

