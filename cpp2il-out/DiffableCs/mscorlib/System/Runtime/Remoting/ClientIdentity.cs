namespace System.Runtime.Remoting;

internal class ClientIdentity : Identity
{
	private WeakReference _proxyReference; //Field offset: 0x48

	public MarshalByRefObject ClientProxy
	{
		 get { } //Length: 138
		 set { } //Length: 109
	}

	public string TargetUri
	{
		 get { } //Length: 42
	}

	public ClientIdentity(string objectUri, ObjRef objRef) { }

	public virtual ObjRef CreateObjRef(Type requestedType) { }

	public MarshalByRefObject get_ClientProxy() { }

	public string get_TargetUri() { }

	public void set_ClientProxy(MarshalByRefObject value) { }

}

