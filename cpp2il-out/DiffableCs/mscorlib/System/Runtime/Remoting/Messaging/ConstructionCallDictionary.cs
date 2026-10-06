namespace System.Runtime.Remoting.Messaging;

internal class ConstructionCallDictionary : MessageDictionary
{
	public static String[] InternalKeys; //Field offset: 0x0

	private static ConstructionCallDictionary() { }

	public ConstructionCallDictionary(IConstructionCallMessage message) { }

	protected virtual object GetMethodProperty(string key) { }

	protected virtual void SetMethodProperty(string key, object value) { }

}

