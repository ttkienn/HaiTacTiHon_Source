namespace System.Xml.Schema;

public class XmlSchemaAnyAttribute : XmlSchemaAnnotated
{
	private string ns; //Field offset: 0x50
	private XmlSchemaContentProcessing processContents; //Field offset: 0x58
	private NamespaceList namespaceList; //Field offset: 0x60

	[XmlAttribute("namespace")]
	public string Namespace
	{
		 set { } //Length: 13
	}

	[XmlIgnore]
	internal NamespaceList NamespaceList
	{
		internal get { } //Length: 5
	}

	[DefaultValue(XmlSchemaContentProcessing::None (0))]
	[XmlAttribute("processContents")]
	public XmlSchemaContentProcessing ProcessContents
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	[XmlIgnore]
	internal XmlSchemaContentProcessing ProcessContentsCorrect
	{
		internal get { } //Length: 15
	}

	public XmlSchemaAnyAttribute() { }

	internal bool Allows(XmlQualifiedName qname) { }

	internal void BuildNamespaceList(string targetNamespace) { }

	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	internal NamespaceList get_NamespaceList() { }

	public XmlSchemaContentProcessing get_ProcessContents() { }

	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super) { }

	public void set_Namespace(string value) { }

	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

}

