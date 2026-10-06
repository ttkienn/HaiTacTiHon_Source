namespace System.Runtime.Remoting;

[ComVisible(True)]
public class InternalRemotingServices
{
	private static Hashtable _soapAttributes; //Field offset: 0x0

	private static InternalRemotingServices() { }

	public static SoapAttribute GetCachedSoapAttribute(object reflectionObject) { }

}

