namespace System.Xml.Schema;

public class XmlSchemaAny : XmlSchemaParticle
{
	private string ns; //Field offset: 0x78
	private XmlSchemaContentProcessing processContents; //Field offset: 0x80
	private NamespaceList namespaceList; //Field offset: 0x88

	[XmlAttribute("namespace")]
	public string Namespace
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	[XmlIgnore]
	internal NamespaceList NamespaceList
	{
		internal get { } //Length: 8
	}

	internal virtual string NameString
	{
		internal get { } //Length: 1020
	}

	[DefaultValue(XmlSchemaContentProcessing::None (0))]
	[XmlAttribute("processContents")]
	public XmlSchemaContentProcessing ProcessContents
	{
		 set { } //Length: 7
	}

	[XmlIgnore]
	internal XmlSchemaContentProcessing ProcessContentsCorrect
	{
		internal get { } //Length: 21
	}

	[XmlIgnore]
	internal string ResolvedNamespace
	{
		internal get { } //Length: 67
	}

	public XmlSchemaAny() { }

	internal bool Allows(XmlQualifiedName qname) { }

	internal void BuildNamespaceList(string targetNamespace) { }

	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	public string get_Namespace() { }

	internal NamespaceList get_NamespaceList() { }

	internal virtual string get_NameString() { }

	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	internal string get_ResolvedNamespace() { }

	public void set_Namespace(string value) { }

	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

}

