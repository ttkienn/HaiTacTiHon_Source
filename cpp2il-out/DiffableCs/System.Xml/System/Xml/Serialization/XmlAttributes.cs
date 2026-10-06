namespace System.Xml.Serialization;

public class XmlAttributes
{
	private XmlAnyAttributeAttribute xmlAnyAttribute; //Field offset: 0x10
	private XmlAnyElementAttributes xmlAnyElements; //Field offset: 0x18
	private XmlArrayAttribute xmlArray; //Field offset: 0x20
	private XmlArrayItemAttributes xmlArrayItems; //Field offset: 0x28
	private XmlAttributeAttribute xmlAttribute; //Field offset: 0x30
	private XmlChoiceIdentifierAttribute xmlChoiceIdentifier; //Field offset: 0x38
	private object xmlDefaultValue; //Field offset: 0x40
	private XmlElementAttributes xmlElements; //Field offset: 0x48
	private XmlEnumAttribute xmlEnum; //Field offset: 0x50
	private bool xmlIgnore; //Field offset: 0x58
	private bool xmlns; //Field offset: 0x59
	private XmlRootAttribute xmlRoot; //Field offset: 0x60
	private XmlTextAttribute xmlText; //Field offset: 0x68
	private XmlTypeAttribute xmlType; //Field offset: 0x70

	internal Nullable<Int32> Order
	{
		internal get { } //Length: 176
	}

	internal int SortableOrder
	{
		internal get { } //Length: 117
	}

	public XmlAnyAttributeAttribute XmlAnyAttribute
	{
		 get { } //Length: 5
	}

	public XmlAnyElementAttributes XmlAnyElements
	{
		 get { } //Length: 5
	}

	public XmlArrayAttribute XmlArray
	{
		 get { } //Length: 5
	}

	public XmlArrayItemAttributes XmlArrayItems
	{
		 get { } //Length: 5
	}

	public XmlAttributeAttribute XmlAttribute
	{
		 get { } //Length: 5
	}

	public XmlChoiceIdentifierAttribute XmlChoiceIdentifier
	{
		 get { } //Length: 5
	}

	public object XmlDefaultValue
	{
		 get { } //Length: 5
	}

	public XmlElementAttributes XmlElements
	{
		 get { } //Length: 5
	}

	public bool XmlIgnore
	{
		 get { } //Length: 5
	}

	public bool Xmlns
	{
		 get { } //Length: 5
	}

	public XmlRootAttribute XmlRoot
	{
		 get { } //Length: 5
	}

	public XmlTextAttribute XmlText
	{
		 get { } //Length: 5
	}

	public XmlTypeAttribute XmlType
	{
		 get { } //Length: 5
	}

	public XmlAttributes() { }

	public XmlAttributes(ICustomAttributeProvider provider) { }

	internal void AddKeyHash(StringBuilder sb) { }

	internal Nullable<Int32> get_Order() { }

	internal int get_SortableOrder() { }

	public XmlAnyAttributeAttribute get_XmlAnyAttribute() { }

	public XmlAnyElementAttributes get_XmlAnyElements() { }

	public XmlArrayAttribute get_XmlArray() { }

	public XmlArrayItemAttributes get_XmlArrayItems() { }

	public XmlAttributeAttribute get_XmlAttribute() { }

	public XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier() { }

	public object get_XmlDefaultValue() { }

	public XmlElementAttributes get_XmlElements() { }

	public bool get_XmlIgnore() { }

	public bool get_Xmlns() { }

	public XmlRootAttribute get_XmlRoot() { }

	public XmlTextAttribute get_XmlText() { }

	public XmlTypeAttribute get_XmlType() { }

}

