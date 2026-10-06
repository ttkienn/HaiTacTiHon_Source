namespace System.Runtime.Remoting.Activation;

internal class RemoteActivationAttribute : Attribute, IContextAttribute
{
	private IList _contextProperties; //Field offset: 0x10

	public RemoteActivationAttribute(IList contextProperties) { }

	public override void GetPropertiesForNewContext(IConstructionCallMessage ctor) { }

	public override bool IsContextOK(Context ctx, IConstructionCallMessage ctor) { }

}

