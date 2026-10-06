namespace System.Data;

public class SyntaxErrorException : InvalidExpressionException
{

	protected SyntaxErrorException(SerializationInfo info, StreamingContext context) { }

	public SyntaxErrorException() { }

	public SyntaxErrorException(string s) { }

}

