namespace System.Xml.Schema;

[DefaultMember("Item")]
[Obsolete("Use System.Xml.Schema.XmlSchemaSet for schema compilation and validation. https://go.microsoft.com/fwlink/?linkid=14202")]
public sealed class XmlSchemaCollection : ICollection, IEnumerable
{
	private Hashtable collection; //Field offset: 0x10
	private XmlNameTable nameTable; //Field offset: 0x18
	private SchemaNames schemaNames; //Field offset: 0x20
	private ReaderWriterLock wLock; //Field offset: 0x28
	private int timeout; //Field offset: 0x30
	private bool isThreadSafe; //Field offset: 0x34
	private ValidationEventHandler validationEventHandler; //Field offset: 0x38
	private XmlResolver xmlResolver; //Field offset: 0x40

	public int Count
	{
		 get { } //Length: 42
	}

	internal ValidationEventHandler EventHandler
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	public XmlSchema Item
	{
		 get { } //Length: 175
	}

	public XmlNameTable NameTable
	{
		 get { } //Length: 5
	}

	private override int System.Collections.ICollection.Count
	{
		private get { } //Length: 42
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 4
	}

	internal XmlResolver XmlResolver
	{
		internal set { } //Length: 13
	}

	public XmlSchemaCollection(XmlNameTable nametable) { }

	private void Add(string ns, XmlSchemaCollectionNode node) { }

	private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver) { }

	internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile) { }

	public int get_Count() { }

	internal ValidationEventHandler get_EventHandler() { }

	public XmlSchema get_Item(string ns) { }

	public XmlNameTable get_NameTable() { }

	public XmlSchemaCollectionEnumerator GetEnumerator() { }

	internal SchemaInfo GetSchemaInfo(string ns) { }

	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	internal void set_EventHandler(ValidationEventHandler value) { }

	internal void set_XmlResolver(XmlResolver value) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override int System.Collections.ICollection.get_Count() { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

