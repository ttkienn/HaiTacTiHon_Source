namespace System.Runtime.Remoting.Activation;

internal class AppDomainLevelActivator : IActivator
{
	private string _activationUrl; //Field offset: 0x10
	private IActivator _next; //Field offset: 0x18

	public override IActivator NextActivator
	{
		 get { } //Length: 5
	}

	public AppDomainLevelActivator(string activationUrl, IActivator next) { }

	public override IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }

	public override IActivator get_NextActivator() { }

}

