namespace System.Runtime.Remoting;

internal class ClientActivatedIdentity : ServerIdentity
{
	private MarshalByRefObject _targetThis; //Field offset: 0x70

	public ClientActivatedIdentity(string objectUri, Type objectType) { }

	public virtual IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

	public MarshalByRefObject GetServerObject() { }

	public virtual void OnLifetimeExpired() { }

	public void SetClientProxy(MarshalByRefObject obj) { }

	public virtual IMessage SyncObjectProcessMessage(IMessage msg) { }

}

