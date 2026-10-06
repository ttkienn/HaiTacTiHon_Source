namespace System.Xml.Schema;

public class XmlSchemaGroupRef : XmlSchemaParticle
{
	private XmlQualifiedName refName; //Field offset: 0x78
	private XmlSchemaGroupBase particle; //Field offset: 0x80
	private XmlSchemaGroup refined; //Field offset: 0x88

	[XmlIgnore]
	public XmlSchemaGroupBase Particle
	{
		 get { } //Length: 8
	}

	[XmlIgnore]
	internal XmlSchemaGroup Redefined
	{
		internal get { } //Length: 8
		internal set { } //Length: 19
	}

	[XmlAttribute("ref")]
	public XmlQualifiedName RefName
	{
		 get { } //Length: 5
		 set { } //Length: 160
	}

	public XmlSchemaGroupRef() { }

	public XmlSchemaGroupBase get_Particle() { }

	internal XmlSchemaGroup get_Redefined() { }

	public XmlQualifiedName get_RefName() { }

	internal void set_Redefined(XmlSchemaGroup value) { }

	public void set_RefName(XmlQualifiedName value) { }

	internal void SetParticle(XmlSchemaGroupBase value) { }

}

