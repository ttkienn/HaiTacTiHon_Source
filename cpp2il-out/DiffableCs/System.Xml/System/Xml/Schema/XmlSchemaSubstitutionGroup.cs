namespace System.Xml.Schema;

internal class XmlSchemaSubstitutionGroup : XmlSchemaObject
{
	private ArrayList membersList; //Field offset: 0x38
	private XmlQualifiedName examplar; //Field offset: 0x40

	[XmlIgnore]
	internal XmlQualifiedName Examplar
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	[XmlIgnore]
	internal ArrayList Members
	{
		internal get { } //Length: 5
	}

	public XmlSchemaSubstitutionGroup() { }

	internal XmlQualifiedName get_Examplar() { }

	internal ArrayList get_Members() { }

	internal void set_Examplar(XmlQualifiedName value) { }

}

