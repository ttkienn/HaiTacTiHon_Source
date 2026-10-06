namespace Mono.Xml;

internal class SecurityParser : SmallXmlParser, IContentHandler
{
	private SecurityElement root; //Field offset: 0x68
	private SecurityElement current; //Field offset: 0x70
	private Stack stack; //Field offset: 0x78

	public SecurityParser() { }

	public void LoadXml(string xml) { }

	public override void OnChars(string ch) { }

	public override void OnEndElement(string name) { }

	public override void OnEndParsing(SmallXmlParser parser) { }

	public override void OnIgnorableWhitespace(string s) { }

	public override void OnProcessingInstruction(string name, string text) { }

	public override void OnStartElement(string name, IAttrList attrs) { }

	public override void OnStartParsing(SmallXmlParser parser) { }

	public SecurityElement ToXml() { }

}

