namespace System.Runtime.Remoting.Activation;

internal class ActivationServices
{
	private static IActivator _constructionActivator; //Field offset: 0x0

	private static IActivator ConstructionActivator
	{
		private get { } //Length: 160
	}

	public static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall) { }

	public static object AllocateUninitializedClassInstance(Type type) { }

	public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, Object[] activationAttributes) { }

	public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall) { }

	public static object CreateProxyForType(Type type) { }

	public static void EnableProxyActivation(Type type, bool enable) { }

	private static IActivator get_ConstructionActivator() { }

	public static IMessage RemoteActivate(IConstructionCallMessage ctorCall) { }

}

