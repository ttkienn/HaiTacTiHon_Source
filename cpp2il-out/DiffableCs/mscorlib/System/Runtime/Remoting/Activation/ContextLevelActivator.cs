namespace System.Runtime.Remoting.Activation;

internal class ContextLevelActivator : IActivator
{
	private IActivator m_NextActivator; //Field offset: 0x10

	public override IActivator NextActivator
	{
		 get { } //Length: 5
	}

	public ContextLevelActivator(IActivator next) { }

	public override IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }

	public override IActivator get_NextActivator() { }

}

