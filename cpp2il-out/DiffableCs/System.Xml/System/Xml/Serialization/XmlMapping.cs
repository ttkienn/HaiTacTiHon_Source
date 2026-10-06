namespace System.Xml.Serialization;

public abstract class XmlMapping
{
	private ObjectMap map; //Field offset: 0x10
	private ArrayList relatedMaps; //Field offset: 0x18
	private SerializationFormat format; //Field offset: 0x20
	private SerializationSource source; //Field offset: 0x28
	internal string _elementName; //Field offset: 0x30
	internal string _namespace; //Field offset: 0x38
	private string key; //Field offset: 0x40

	public string ElementName
	{
		 get { } //Length: 5
	}

	internal SerializationFormat Format
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	public string Namespace
	{
		 get { } //Length: 5
	}

	internal ObjectMap ObjectMap
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	internal ArrayList RelatedMaps
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	internal SerializationSource Source
	{
		internal get { } //Length: 5
	}

	internal XmlMapping(string elementName, string ns) { }

	public string get_ElementName() { }

	internal SerializationFormat get_Format() { }

	public string get_Namespace() { }

	internal ObjectMap get_ObjectMap() { }

	internal ArrayList get_RelatedMaps() { }

	internal SerializationSource get_Source() { }

	internal void set_Format(SerializationFormat value) { }

	internal void set_ObjectMap(ObjectMap value) { }

	internal void set_RelatedMaps(ArrayList value) { }

	public void SetKey(string key) { }

}

