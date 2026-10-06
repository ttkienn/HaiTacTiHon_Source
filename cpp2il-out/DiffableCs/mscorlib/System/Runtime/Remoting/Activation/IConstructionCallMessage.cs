namespace System.Runtime.Remoting.Activation;

[ComVisible(True)]
public interface IConstructionCallMessage : IMessage, IMethodCallMessage, IMethodMessage
{

	public Type ActivationType
	{
		 get { } //Length: 0
	}

	public string ActivationTypeName
	{
		 get { } //Length: 0
	}

	public IActivator Activator
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Object[] CallSiteActivationAttributes
	{
		 get { } //Length: 0
	}

	public IList ContextProperties
	{
		 get { } //Length: 0
	}

	public Type get_ActivationType() { }

	public string get_ActivationTypeName() { }

	public IActivator get_Activator() { }

	public Object[] get_CallSiteActivationAttributes() { }

	public IList get_ContextProperties() { }

	public void set_Activator(IActivator value) { }

}

