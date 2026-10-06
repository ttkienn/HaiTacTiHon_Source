namespace System.Security;

public sealed class XmlSyntaxException : SystemException
{

	public XmlSyntaxException() { }

	public XmlSyntaxException(int lineNumber) { }

	public XmlSyntaxException(int lineNumber, string message) { }

	private XmlSyntaxException(SerializationInfo info, StreamingContext context) { }

}

