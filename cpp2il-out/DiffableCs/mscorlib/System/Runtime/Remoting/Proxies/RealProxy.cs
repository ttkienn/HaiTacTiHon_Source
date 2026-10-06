namespace System.Runtime.Remoting.Proxies;

[ComVisible(True)]
public abstract class RealProxy
{
	private Type class_to_proxy; //Field offset: 0x10
	internal Context _targetContext; //Field offset: 0x18
	internal MarshalByRefObject _server; //Field offset: 0x20
	private int _targetDomainId; //Field offset: 0x28
	internal string _targetUri; //Field offset: 0x30
	internal Identity _objectIdentity; //Field offset: 0x38
	private object _objTP; //Field offset: 0x40
	private object _stubData; //Field offset: 0x48

	internal Identity ObjectIdentity
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	protected RealProxy() { }

	protected RealProxy(Type classToProxy) { }

	internal RealProxy(Type classToProxy, ClientIdentity identity) { }

	protected RealProxy(Type classToProxy, IntPtr stub, object stubData) { }

	protected void AttachServer(MarshalByRefObject s) { }

	internal Identity get_ObjectIdentity() { }

	internal object GetAppDomainTarget() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public Type GetProxiedType() { }

	public override object GetTransparentProxy() { }

	private static Type InternalGetProxyType(object transparentProxy) { }

	internal override object InternalGetTransparentProxy(string className) { }

	public abstract IMessage Invoke(IMessage msg) { }

	internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out Object[] out_args) { }

	private static Object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call) { }

	internal void set_ObjectIdentity(Identity value) { }

	internal void SetTargetDomain(int domainId) { }

}

