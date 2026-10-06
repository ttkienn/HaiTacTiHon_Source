namespace UnityEngine.Purchasing;

public class NullReceiptException : ReceiptParserException
{

	public NullReceiptException() { }

	public NullReceiptException(string message) { }

	protected NullReceiptException(SerializationInfo info, StreamingContext context) { }

}

