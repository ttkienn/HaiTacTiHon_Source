namespace System.Xml;

internal interface IDtdInfo
{

	public bool HasDefaultAttributes
	{
		 get { } //Length: 0
	}

	public bool HasNonCDataAttributes
	{
		 get { } //Length: 0
	}

	public string InternalDtdSubset
	{
		 get { } //Length: 0
	}

	public XmlQualifiedName Name
	{
		 get { } //Length: 0
	}

	public bool get_HasDefaultAttributes() { }

	public bool get_HasNonCDataAttributes() { }

	public string get_InternalDtdSubset() { }

	public XmlQualifiedName get_Name() { }

	public IDtdAttributeListInfo LookupAttributeList(string prefix, string localName) { }

	public IDtdEntityInfo LookupEntity(string name) { }

}

