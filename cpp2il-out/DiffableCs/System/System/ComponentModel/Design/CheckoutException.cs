namespace System.ComponentModel.Design;

public class CheckoutException : ExternalException
{
	public static readonly CheckoutException Canceled; //Field offset: 0x0

	private static CheckoutException() { }

	public CheckoutException() { }

	public CheckoutException(string message, int errorCode) { }

	protected CheckoutException(SerializationInfo info, StreamingContext context) { }

}

