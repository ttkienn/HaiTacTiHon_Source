namespace System.Runtime.Remoting;

internal abstract class ServerIdentity : Identity
{
	protected Type _objectType; //Field offset: 0x48
	protected MarshalByRefObject _serverObject; //Field offset: 0x50
	protected IMessageSink _serverSink; //Field offset: 0x58
	protected Context _context; //Field offset: 0x60
	protected Lease _lease; //Field offset: 0x68

	public Context Context
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public Lease Lease
	{
		 get { } //Length: 5
	}

	public Type ObjectType
	{
		 get { } //Length: 5
	}

	public ServerIdentity(string objectUri, Context context, Type objectType) { }

	public abstract IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

	public void AttachServerObject(MarshalByRefObject serverObject, Context context) { }

	public virtual ObjRef CreateObjRef(Type requestedType) { }

	protected void DisposeServerObject() { }

	public Context get_Context() { }

	public Lease get_Lease() { }

	public Type get_ObjectType() { }

	public override void OnLifetimeExpired() { }

	public void set_Context(Context value) { }

	public void StartTrackingLifetime(ILease lease) { }

	public abstract IMessage SyncObjectProcessMessage(IMessage msg) { }

}

