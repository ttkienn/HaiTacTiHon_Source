namespace System.Xml;

internal struct XmlCharType
{
	private static object s_Lock; //Field offset: 0x0
	private static Byte[] s_CharProperties; //Field offset: 0x8
	internal Byte[] charProperties; //Field offset: 0x0

	public static XmlCharType Instance
	{
		 get { } //Length: 121
	}

	private static object StaticLock
	{
		private get { } //Length: 146
	}

	private XmlCharType(Byte[] charProperties) { }

	internal static int CombineSurrogateChar(int lowChar, int highChar) { }

	public static XmlCharType get_Instance() { }

	private static object get_StaticLock() { }

	private static void InitInstance() { }

	private static bool InRange(int value, int start, int end) { }

	public bool IsCharData(char ch) { }

	public static bool IsDigit(char ch) { }

	internal static bool IsHighSurrogate(int ch) { }

	public bool IsLetter(char ch) { }

	internal static bool IsLowSurrogate(int ch) { }

	public bool IsNameCharXml4e(char ch) { }

	public bool IsNameSingleChar(char ch) { }

	public bool IsNCNameCharXml4e(char ch) { }

	public bool IsNCNameSingleChar(char ch) { }

	internal int IsOnlyCharData(string str) { }

	internal static bool IsOnlyDigits(string str, int startPos, int len) { }

	internal bool IsOnlyWhitespace(string str) { }

	internal int IsOnlyWhitespaceWithPos(string str) { }

	public bool IsPubidChar(char ch) { }

	internal int IsPublicId(string str) { }

	public bool IsStartNCNameCharXml4e(char ch) { }

	public bool IsStartNCNameSingleChar(char ch) { }

	internal static bool IsSurrogate(int ch) { }

	internal bool IsTextChar(char ch) { }

	public bool IsWhiteSpace(char ch) { }

	private static void SetProperties(Byte[] chProps, string ranges, byte value) { }

	internal static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar) { }

}

