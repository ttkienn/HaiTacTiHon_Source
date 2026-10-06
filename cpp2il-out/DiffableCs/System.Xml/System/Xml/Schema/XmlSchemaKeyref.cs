namespace System.Xml.Schema;

public class XmlSchemaKeyref : XmlSchemaIdentityConstraint
{
	private XmlQualifiedName refer; //Field offset: 0x78

	[XmlAttribute("refer")]
	public XmlQualifiedName Refer
	{
		 get { } //Length: 5
		 set { } //Length: 160
	}

	public XmlSchemaKeyref() { }

	public XmlQualifiedName get_Refer() { }

	public void set_Refer(XmlQualifiedName value) { }

}

