namespace UnityEngine.Purchasing;

public class InvalidProductTypeException : ReceiptParserException
{

	public InvalidProductTypeException() { }

	public InvalidProductTypeException(string message) { }

	protected InvalidProductTypeException(SerializationInfo info, StreamingContext context) { }

}

