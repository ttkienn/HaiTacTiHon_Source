namespace System.Runtime.Remoting;

internal class SingleCallIdentity : ServerIdentity
{

	public SingleCallIdentity(string objectUri, Context context, Type objectType) { }

	public virtual IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

	public virtual IMessage SyncObjectProcessMessage(IMessage msg) { }

}

