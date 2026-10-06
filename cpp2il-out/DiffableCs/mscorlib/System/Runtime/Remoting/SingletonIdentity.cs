namespace System.Runtime.Remoting;

internal class SingletonIdentity : ServerIdentity
{

	public SingletonIdentity(string objectUri, Context context, Type objectType) { }

	public virtual IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

	public MarshalByRefObject GetServerObject() { }

	public virtual IMessage SyncObjectProcessMessage(IMessage msg) { }

}

