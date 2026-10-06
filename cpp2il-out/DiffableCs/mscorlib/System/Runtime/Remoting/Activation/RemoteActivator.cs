namespace System.Runtime.Remoting.Activation;

internal class RemoteActivator : MarshalByRefObject, IActivator
{

	public override IActivator NextActivator
	{
		 get { } //Length: 62
	}

	public override IConstructionReturnMessage Activate(IConstructionCallMessage msg) { }

	public override IActivator get_NextActivator() { }

}

