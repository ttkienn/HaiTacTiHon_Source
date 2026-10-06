namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode
{
	[Nullable(1)]
	private readonly XmlDocumentType _documentType; //Field offset: 0x28

	public override string InternalSubset
	{
		 get { } //Length: 27
	}

	public virtual string LocalName
	{
		 get { } //Length: 44
	}

	[Nullable(1)]
	public override string Name
	{
		[NullableContext(1)]
		 get { } //Length: 42
	}

	public override string Public
	{
		 get { } //Length: 27
	}

	public override string System
	{
		 get { } //Length: 27
	}

	[NullableContext(1)]
	public XmlDocumentTypeWrapper(XmlDocumentType documentType) { }

	public override string get_InternalSubset() { }

	public virtual string get_LocalName() { }

	[NullableContext(1)]
	public override string get_Name() { }

	public override string get_Public() { }

	public override string get_System() { }

}

