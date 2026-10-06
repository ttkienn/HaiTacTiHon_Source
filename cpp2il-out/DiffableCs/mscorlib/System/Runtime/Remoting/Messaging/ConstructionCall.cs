namespace System.Runtime.Remoting.Messaging;

[CLSCompliant(False)]
[ComVisible(True)]
public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage
{
	private IActivator _activator; //Field offset: 0x68
	private Object[] _activationAttributes; //Field offset: 0x70
	private IList _contextProperties; //Field offset: 0x78
	private Type _activationType; //Field offset: 0x80
	private string _activationTypeName; //Field offset: 0x88
	private bool _isContextOk; //Field offset: 0x90
	private RemotingProxy _sourceProxy; //Field offset: 0x98

	public override Type ActivationType
	{
		 get { } //Length: 200
	}

	public override string ActivationTypeName
	{
		 get { } //Length: 8
	}

	public override IActivator Activator
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public override Object[] CallSiteActivationAttributes
	{
		 get { } //Length: 5
	}

	public override IList ContextProperties
	{
		 get { } //Length: 105
	}

	internal bool IsContextOk
	{
		internal get { } //Length: 8
		internal set { } //Length: 7
	}

	public virtual IDictionary Properties
	{
		 get { } //Length: 55
	}

	internal RemotingProxy SourceProxy
	{
		internal get { } //Length: 8
		internal set { } //Length: 19
	}

	internal ConstructionCall(Type type) { }

	internal ConstructionCall(SerializationInfo info, StreamingContext context) { }

	public override Type get_ActivationType() { }

	public override string get_ActivationTypeName() { }

	public override IActivator get_Activator() { }

	public override Object[] get_CallSiteActivationAttributes() { }

	public override IList get_ContextProperties() { }

	internal bool get_IsContextOk() { }

	public virtual IDictionary get_Properties() { }

	internal RemotingProxy get_SourceProxy() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal virtual void InitDictionary() { }

	internal virtual void InitMethodProperty(string key, object value) { }

	public override void set_Activator(IActivator value) { }

	internal void set_IsContextOk(bool value) { }

	internal void set_SourceProxy(RemotingProxy value) { }

	internal void SetActivationAttributes(Object[] attributes) { }

}

