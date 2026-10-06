namespace System.Xml;

public class XmlException : SystemException
{
	private string res; //Field offset: 0x90
	private String[] args; //Field offset: 0x98
	private int lineNumber; //Field offset: 0xA0
	private int linePosition; //Field offset: 0xA4
	[OptionalField]
	private string sourceUri; //Field offset: 0xA8
	private string message; //Field offset: 0xB0

	public int LineNumber
	{
		 get { } //Length: 7
	}

	public int LinePosition
	{
		 get { } //Length: 7
	}

	public virtual string Message
	{
		 get { } //Length: 25
	}

	internal string ResString
	{
		internal get { } //Length: 8
	}

	protected XmlException(SerializationInfo info, StreamingContext context) { }

	internal XmlException(string res, String[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	internal XmlException(string res, String[] args, Exception innerException, int lineNumber, int linePosition) { }

	internal XmlException(string res, String[] args, int lineNumber, int linePosition, string sourceUri) { }

	internal XmlException(string res, String[] args, int lineNumber, int linePosition) { }

	internal XmlException(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

	internal XmlException(string res, String[] args, IXmlLineInfo lineInfo, string sourceUri) { }

	internal XmlException(string res, String[] args, IXmlLineInfo lineInfo) { }

	internal XmlException(string res, string arg, IXmlLineInfo lineInfo) { }

	internal XmlException(string res, string arg, int lineNumber, int linePosition) { }

	internal XmlException(string res, string arg) { }

	internal XmlException(string res, String[] args) { }

	internal XmlException(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	public XmlException(string message, Exception innerException, int lineNumber, int linePosition) { }

	public XmlException(string message, Exception innerException) { }

	public XmlException(string message) { }

	public XmlException() { }

	internal XmlException(string res, string arg, string sourceUri) { }

	internal static String[] BuildCharExceptionArgs(string data, int invCharIndex) { }

	internal static String[] BuildCharExceptionArgs(Char[] data, int length, int invCharIndex) { }

	internal static String[] BuildCharExceptionArgs(char invChar, char nextChar) { }

	private static string CreateMessage(string res, String[] args, int lineNumber, int linePosition) { }

	private static string FormatUserMessage(string message, int lineNumber, int linePosition) { }

	public int get_LineNumber() { }

	public int get_LinePosition() { }

	public virtual string get_Message() { }

	internal string get_ResString() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

