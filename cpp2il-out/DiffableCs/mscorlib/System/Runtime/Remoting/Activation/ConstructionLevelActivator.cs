namespace System.Runtime.Remoting.Activation;

internal class ConstructionLevelActivator : IActivator
{

	public override IActivator NextActivator
	{
		 get { } //Length: 3
	}

	public ConstructionLevelActivator() { }

	public override IConstructionReturnMessage Activate(IConstructionCallMessage msg) { }

	public override IActivator get_NextActivator() { }

}

