namespace System.Xml;

[DefaultMember("ItemOf")]
public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable
{

	public XmlAttribute ItemOf
	{
		 get { } //Length: 235
	}

	public XmlAttribute ItemOf
	{
		 get { } //Length: 289
	}

	public XmlAttribute ItemOf
	{
		 get { } //Length: 335
	}

	private override int System.Collections.ICollection.Count
	{
		private get { } //Length: 7
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 4
	}

	internal XmlAttributeCollection(XmlNode parent) { }

	internal virtual XmlNode AddNode(XmlNode node) { }

	public XmlAttribute Append(XmlAttribute node) { }

	internal void Detach(XmlAttribute attr) { }

	internal int FindNodeOffsetNS(XmlAttribute node) { }

	public XmlAttribute get_ItemOf(int i) { }

	public XmlAttribute get_ItemOf(string name) { }

	public XmlAttribute get_ItemOf(string localName, string namespaceURI) { }

	internal virtual XmlNode InsertNodeAt(int i, XmlNode node) { }

	internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

	internal XmlAttribute InternalAppendAttribute(XmlAttribute node) { }

	internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName) { }

	public XmlAttribute Remove(XmlAttribute node) { }

	public void RemoveAll() { }

	public XmlAttribute RemoveAt(int i) { }

	internal int RemoveDuplicateAttribute(XmlAttribute attr) { }

	internal virtual XmlNode RemoveNodeAt(int i) { }

	internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

	internal void ResetParentInElementIdAttrMap(string oldVal, string newVal) { }

	public virtual XmlNode SetNamedItem(XmlNode node) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override int System.Collections.ICollection.get_Count() { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

}

