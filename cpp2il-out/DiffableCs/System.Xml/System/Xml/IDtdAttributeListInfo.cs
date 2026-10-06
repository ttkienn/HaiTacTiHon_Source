namespace System.Xml;

internal interface IDtdAttributeListInfo
{

	public bool HasNonCDataAttributes
	{
		 get { } //Length: 0
	}

	public bool get_HasNonCDataAttributes() { }

	public IDtdAttributeInfo LookupAttribute(string prefix, string localName) { }

	public IEnumerable<IDtdDefaultAttributeInfo> LookupDefaultAttributes() { }

}

