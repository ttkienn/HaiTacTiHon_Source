namespace Mono.Xml;

internal class SmallXmlParser
{
	private class AttrListImpl : IAttrList
	{
		private List<String> attrNames; //Field offset: 0x10
		private List<String> attrValues; //Field offset: 0x18

		public override int Length
		{
			 get { } //Length: 60
		}

		public override String[] Names
		{
			 get { } //Length: 68
		}

		public override String[] Values
		{
			 get { } //Length: 68
		}

		public AttrListImpl() { }

		internal void Add(string name, string value) { }

		internal void Clear() { }

		public override int get_Length() { }

		public override String[] get_Names() { }

		public override String[] get_Values() { }

		public override string GetName(int i) { }

		public override string GetValue(int i) { }

		public override string GetValue(string name) { }

	}

	internal interface IAttrList
	{

		public int Length
		{
			 get { } //Length: 0
		}

		public String[] Names
		{
			 get { } //Length: 0
		}

		public String[] Values
		{
			 get { } //Length: 0
		}

		public int get_Length() { }

		public String[] get_Names() { }

		public String[] get_Values() { }

		public string GetName(int i) { }

		public string GetValue(int i) { }

		public string GetValue(string name) { }

	}

	internal interface IContentHandler
	{

		public void OnChars(string text) { }

		public void OnEndElement(string name) { }

		public void OnEndParsing(SmallXmlParser parser) { }

		public void OnIgnorableWhitespace(string text) { }

		public void OnProcessingInstruction(string name, string text) { }

		public void OnStartElement(string name, IAttrList attrs) { }

		public void OnStartParsing(SmallXmlParser parser) { }

	}

	private IContentHandler handler; //Field offset: 0x10
	private TextReader reader; //Field offset: 0x18
	private Stack elementNames; //Field offset: 0x20
	private Stack xmlSpaces; //Field offset: 0x28
	private string xmlSpace; //Field offset: 0x30
	private StringBuilder buffer; //Field offset: 0x38
	private Char[] nameBuffer; //Field offset: 0x40
	private bool isWhitespace; //Field offset: 0x48
	private AttrListImpl attributes; //Field offset: 0x50
	private int line; //Field offset: 0x58
	private int column; //Field offset: 0x5C
	private bool resetColumn; //Field offset: 0x60

	public SmallXmlParser() { }

	private void Cleanup() { }

	private Exception Error(string msg) { }

	public void Expect(int c) { }

	private void HandleBufferedContent() { }

	private void HandleWhitespaces() { }

	private bool IsNameChar(char c, bool start) { }

	private bool IsWhitespace(int c) { }

	public void Parse(TextReader input, IContentHandler handler) { }

	private int Peek() { }

	private int Read() { }

	private void ReadAttribute(AttrListImpl a) { }

	private void ReadCDATASection() { }

	private int ReadCharacterReference() { }

	private void ReadCharacters() { }

	private void ReadComment() { }

	public void ReadContent() { }

	public string ReadName() { }

	private void ReadReference() { }

	private string ReadUntil(char until, bool handleReferences) { }

	public void SkipWhitespaces(bool expected) { }

	public void SkipWhitespaces() { }

	private Exception UnexpectedEndError() { }

}

