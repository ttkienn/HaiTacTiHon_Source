namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode
{
	[Nullable(1)]
	private readonly XmlDeclaration _declaration; //Field offset: 0x28

	public override string Encoding
	{
		 get { } //Length: 27
		 set { } //Length: 30
	}

	public override string Standalone
	{
		 get { } //Length: 27
		 set { } //Length: 30
	}

	public override string Version
	{
		 get { } //Length: 27
	}

	[NullableContext(1)]
	public XmlDeclarationWrapper(XmlDeclaration declaration) { }

	public override string get_Encoding() { }

	public override string get_Standalone() { }

	public override string get_Version() { }

	public override void set_Encoding(string value) { }

	public override void set_Standalone(string value) { }

}

