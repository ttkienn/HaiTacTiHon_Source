namespace System.Xml;

[DebuggerDisplay("{debuggerDisplayProxy}")]
[DefaultMember("Item")]
public abstract class XmlNode : ICloneable, IEnumerable
{
	internal XmlNode parentNode; //Field offset: 0x10

	public override XmlAttributeCollection Attributes
	{
		 get { } //Length: 3
	}

	public override string BaseURI
	{
		 get { } //Length: 272
	}

	public override XmlNodeList ChildNodes
	{
		 get { } //Length: 84
	}

	internal XmlDocument Document
	{
		internal get { } //Length: 155
	}

	public override XmlNode FirstChild
	{
		 get { } //Length: 42
	}

	public override bool HasChildNodes
	{
		 get { } //Length: 34
	}

	public override string InnerText
	{
		 get { } //Length: 296
		 set { } //Length: 265
	}

	public override string InnerXml
	{
		 set { } //Length: 95
	}

	internal override bool IsContainer
	{
		internal get { } //Length: 3
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 219
	}

	internal override bool IsText
	{
		internal get { } //Length: 3
	}

	public override XmlNode LastChild
	{
		 get { } //Length: 20
	}

	internal override XmlLinkedNode LastNode
	{
		internal get { } //Length: 3
		internal set { } //Length: 3
	}

	public abstract string LocalName
	{
		 get { } //Length: 0
	}

	public abstract string Name
	{
		 get { } //Length: 0
	}

	public override string NamespaceURI
	{
		 get { } //Length: 54
	}

	public override XmlNode NextSibling
	{
		 get { } //Length: 3
	}

	public abstract XmlNodeType NodeType
	{
		 get { } //Length: 0
	}

	public override XmlDocument OwnerDocument
	{
		 get { } //Length: 190
	}

	public override XmlNode ParentNode
	{
		 get { } //Length: 240
	}

	public override string Prefix
	{
		 get { } //Length: 54
		 set { } //Length: 3
	}

	public override XmlNode PreviousSibling
	{
		 get { } //Length: 3
	}

	public override IXmlSchemaInfo SchemaInfo
	{
		 get { } //Length: 79
	}

	public override string Value
	{
		 get { } //Length: 3
		 set { } //Length: 212
	}

	internal override string XmlLang
	{
		internal get { } //Length: 277
	}

	internal override XmlSpace XmlSpace
	{
		internal get { } //Length: 396
	}

	internal XmlNode() { }

	internal XmlNode(XmlDocument doc) { }

	internal override void AfterEvent(XmlNodeChangedEventArgs args) { }

	internal bool AncestorNode(XmlNode node) { }

	public override XmlNode AppendChild(XmlNode newChild) { }

	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	private void AppendChildText(StringBuilder builder) { }

	internal override void BeforeEvent(XmlNodeChangedEventArgs args) { }

	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	public abstract XmlNode CloneNode(bool deep) { }

	internal override void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

	internal override XmlNode FindChild(XmlNodeType type) { }

	public override XmlAttributeCollection get_Attributes() { }

	public override string get_BaseURI() { }

	public override XmlNodeList get_ChildNodes() { }

	internal XmlDocument get_Document() { }

	public override XmlNode get_FirstChild() { }

	public override bool get_HasChildNodes() { }

	public override string get_InnerText() { }

	internal override bool get_IsContainer() { }

	public override bool get_IsReadOnly() { }

	internal override bool get_IsText() { }

	public override XmlNode get_LastChild() { }

	internal override XmlLinkedNode get_LastNode() { }

	public abstract string get_LocalName() { }

	public abstract string get_Name() { }

	public override string get_NamespaceURI() { }

	public override XmlNode get_NextSibling() { }

	public abstract XmlNodeType get_NodeType() { }

	public override XmlDocument get_OwnerDocument() { }

	public override XmlNode get_ParentNode() { }

	public override string get_Prefix() { }

	public override XmlNode get_PreviousSibling() { }

	public override IXmlSchemaInfo get_SchemaInfo() { }

	public override string get_Value() { }

	internal override string get_XmlLang() { }

	internal override XmlSpace get_XmlSpace() { }

	public IEnumerator GetEnumerator() { }

	internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	public override string GetPrefixOfNamespace(string namespaceURI) { }

	internal string GetPrefixOfNamespaceStrict(string namespaceURI) { }

	internal static bool HasReadOnlyParent(XmlNode n) { }

	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	internal override bool IsValidChildType(XmlNodeType type) { }

	internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	public override XmlNode PrependChild(XmlNode newChild) { }

	public override void RemoveAll() { }

	public override XmlNode RemoveChild(XmlNode oldChild) { }

	public override void set_InnerText(string value) { }

	public override void set_InnerXml(string value) { }

	internal override void set_LastNode(XmlLinkedNode value) { }

	public override void set_Prefix(string value) { }

	public override void set_Value(string value) { }

	internal override void SetParent(XmlNode node) { }

	internal override void SetParentForLoad(XmlNode node) { }

	internal static void SplitName(string name, out string prefix, out string localName) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override object System.ICloneable.Clone() { }

	internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	public abstract void WriteContentTo(XmlWriter w) { }

	public abstract void WriteTo(XmlWriter w) { }

}

