namespace System.Runtime.Remoting.Messaging;

internal class MethodReturnDictionary : MessageDictionary
{
	public static String[] InternalReturnKeys; //Field offset: 0x0
	public static String[] InternalExceptionKeys; //Field offset: 0x8

	private static MethodReturnDictionary() { }

	public MethodReturnDictionary(IMethodReturnMessage message) { }

}

