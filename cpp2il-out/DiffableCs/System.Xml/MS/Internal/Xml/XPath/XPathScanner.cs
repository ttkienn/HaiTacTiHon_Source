namespace MS.Internal.Xml.XPath;

internal sealed class XPathScanner
{
	internal enum LexKind
	{
		Comma = 44,
		Slash = 47,
		At = 64,
		Dot = 46,
		LParens = 40,
		RParens = 41,
		LBracket = 91,
		RBracket = 93,
		Star = 42,
		Plus = 43,
		Minus = 45,
		Eq = 61,
		Lt = 60,
		Gt = 62,
		Bang = 33,
		Dollar = 36,
		Apos = 39,
		Quote = 34,
		Union = 124,
		Ne = 78,
		Le = 76,
		Ge = 71,
		And = 65,
		Or = 79,
		DotDot = 68,
		SlashSlash = 83,
		Name = 110,
		String = 115,
		Number = 100,
		Axe = 97,
		Eof = 69,
	}

	private string _xpathExpr; //Field offset: 0x10
	private int _xpathExprIndex; //Field offset: 0x18
	private LexKind _kind; //Field offset: 0x1C
	private char _currentChar; //Field offset: 0x20
	private string _name; //Field offset: 0x28
	private string _prefix; //Field offset: 0x30
	private string _stringValue; //Field offset: 0x38
	private double _numberValue; //Field offset: 0x40
	private bool _canBeFunction; //Field offset: 0x48
	private XmlCharType _xmlCharType; //Field offset: 0x50

	public bool CanBeFunction
	{
		 get { } //Length: 5
	}

	private char CurrentChar
	{
		private get { } //Length: 5
	}

	public LexKind Kind
	{
		 get { } //Length: 4
	}

	public string Name
	{
		 get { } //Length: 5
	}

	public double NumberValue
	{
		 get { } //Length: 6
	}

	public string Prefix
	{
		 get { } //Length: 5
	}

	public string SourceText
	{
		 get { } //Length: 5
	}

	public string StringValue
	{
		 get { } //Length: 5
	}

	public XPathScanner(string xpathExpr) { }

	public bool get_CanBeFunction() { }

	private char get_CurrentChar() { }

	public LexKind get_Kind() { }

	public string get_Name() { }

	public double get_NumberValue() { }

	public string get_Prefix() { }

	public string get_SourceText() { }

	public string get_StringValue() { }

	private bool NextChar() { }

	public bool NextLex() { }

	private double ScanFraction() { }

	private string ScanName() { }

	private double ScanNumber() { }

	private string ScanString() { }

	private void SkipSpace() { }

}

