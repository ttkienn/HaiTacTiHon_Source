namespace System.Xml.Serialization;

[MonoTODO]
public abstract class XmlSerializationReader : XmlSerializationGeneratedCode
{
	internal class CollectionFixup
	{
		private XmlSerializationCollectionFixupCallback callback; //Field offset: 0x10
		private object collection; //Field offset: 0x18
		private object collectionItems; //Field offset: 0x20
		private string id; //Field offset: 0x28

		public XmlSerializationCollectionFixupCallback Callback
		{
			 get { } //Length: 5
		}

		public object Collection
		{
			 get { } //Length: 5
		}

		public internal object CollectionItems
		{
			 get { } //Length: 5
			internal set { } //Length: 13
		}

		internal object Id
		{
			internal get { } //Length: 5
		}

		internal CollectionFixup(object collection, XmlSerializationCollectionFixupCallback callback, string id) { }

		public XmlSerializationCollectionFixupCallback get_Callback() { }

		public object get_Collection() { }

		public object get_CollectionItems() { }

		internal object get_Id() { }

		internal void set_CollectionItems(object value) { }

	}

	private class CollectionItemFixup
	{
		private Array list; //Field offset: 0x10
		private int index; //Field offset: 0x18
		private string id; //Field offset: 0x20

		public Array Collection
		{
			 get { } //Length: 5
		}

		public string Id
		{
			 get { } //Length: 5
		}

		public int Index
		{
			 get { } //Length: 4
		}

		public CollectionItemFixup(Array list, int index, string id) { }

		public Array get_Collection() { }

		public string get_Id() { }

		public int get_Index() { }

	}

	internal class Fixup
	{
		private object source; //Field offset: 0x10
		private String[] ids; //Field offset: 0x18
		private XmlSerializationFixupCallback callback; //Field offset: 0x20

		public XmlSerializationFixupCallback Callback
		{
			 get { } //Length: 5
		}

		public String[] Ids
		{
			 get { } //Length: 5
		}

		public object Source
		{
			 get { } //Length: 5
		}

		public Fixup(object o, XmlSerializationFixupCallback callback, int count) { }

		public XmlSerializationFixupCallback get_Callback() { }

		public String[] get_Ids() { }

		public object get_Source() { }

	}

	private class WriteCallbackInfo
	{
		public Type Type; //Field offset: 0x10
		public string TypeName; //Field offset: 0x18
		public string TypeNs; //Field offset: 0x20
		public XmlSerializationReadCallback Callback; //Field offset: 0x28

		public WriteCallbackInfo() { }

	}

	private XmlDocument document; //Field offset: 0x10
	private XmlReader reader; //Field offset: 0x18
	private ArrayList fixups; //Field offset: 0x20
	private Hashtable collFixups; //Field offset: 0x28
	private ArrayList collItemFixups; //Field offset: 0x30
	private Hashtable typesCallbacks; //Field offset: 0x38
	private ArrayList noIDTargets; //Field offset: 0x40
	private Hashtable targets; //Field offset: 0x48
	private Hashtable delayedListFixups; //Field offset: 0x50
	private XmlSerializer eventSource; //Field offset: 0x58
	private int delayedFixupId; //Field offset: 0x60
	private Hashtable referencedObjects; //Field offset: 0x68
	private int readCount; //Field offset: 0x70
	private int whileIterationCount; //Field offset: 0x74
	private string w3SchemaNS; //Field offset: 0x78
	private string w3InstanceNS; //Field offset: 0x80
	private string w3InstanceNS2000; //Field offset: 0x88
	private string w3InstanceNS1999; //Field offset: 0x90
	private string soapNS; //Field offset: 0x98
	private string wsdlNS; //Field offset: 0xA0
	private string nullX; //Field offset: 0xA8
	private string nil; //Field offset: 0xB0
	private string typeX; //Field offset: 0xB8
	private string arrayType; //Field offset: 0xC0
	private XmlQualifiedName arrayQName; //Field offset: 0xC8

	protected XmlDocument Document
	{
		 get { } //Length: 155
	}

	protected XmlReader Reader
	{
		 get { } //Length: 5
	}

	protected XmlSerializationReader() { }

	private void AddFixup(CollectionItemFixup fixup) { }

	protected void AddFixup(Fixup fixup) { }

	protected void AddFixup(CollectionFixup fixup) { }

	protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read) { }

	protected void AddTarget(string id, object o) { }

	protected Exception CreateReadOnlyCollectionException(string name) { }

	protected Exception CreateUnknownConstantException(string value, Type enumType) { }

	protected Exception CreateUnknownNodeException() { }

	protected Exception CreateUnknownTypeException(XmlQualifiedName type) { }

	private string CurrentTag() { }

	protected Array EnsureArrayIndex(Array a, int index, Type elementType) { }

	private ArrayList EnsureArrayList(ArrayList list) { }

	private Hashtable EnsureHashtable(Hashtable hash) { }

	protected XmlDocument get_Document() { }

	protected XmlReader get_Reader() { }

	private WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname) { }

	protected bool GetNullAttr() { }

	protected object GetTarget(string id) { }

	protected XmlQualifiedName GetXsiType() { }

	protected abstract void InitCallbacks() { }

	internal void Initialize(XmlReader reader, XmlSerializer eventSource) { }

	protected abstract void InitIDs() { }

	protected bool IsXmlnsAttribute(string name) { }

	private void OnUnknownNode(XmlNode node, object o, string qnames) { }

	protected void ParseWsdlArrayType(XmlAttribute attr) { }

	protected XmlQualifiedName ReadElementQualifiedName() { }

	protected void ReadEndElement() { }

	private bool ReadList(out object resultList) { }

	protected bool ReadNull() { }

	protected XmlQualifiedName ReadNullableQualifiedName() { }

	protected string ReadNullableString() { }

	protected object ReadReferencedElement() { }

	protected object ReadReferencedElement(string name, string ns) { }

	protected void ReadReferencedElements() { }

	protected object ReadReferencingElement(out string fixupReference) { }

	protected object ReadReferencingElement(string name, string ns, out string fixupReference) { }

	protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference) { }

	protected IXmlSerializable ReadSerializable(IXmlSerializable serializable) { }

	protected object ReadTypedPrimitive(XmlQualifiedName type) { }

	private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown) { }

	protected XmlDocument ReadXmlDocument(bool wrapped) { }

	protected XmlNode ReadXmlNode(bool wrapped) { }

	protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable) { }

	private bool TargetReady(string id) { }

	protected XmlQualifiedName ToXmlQualifiedName(string value) { }

	protected void UnknownAttribute(object o, XmlAttribute attr, string qnames) { }

	protected void UnknownElement(object o, XmlElement elem, string qnames) { }

	protected void UnknownNode(object o) { }

	protected void UnknownNode(object o, string qnames) { }

	protected void UnreferencedObject(string id, object o) { }

}

