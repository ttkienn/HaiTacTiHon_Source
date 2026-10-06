namespace System.Runtime.Remoting.Messaging;

internal class ServerObjectReplySink : IMessageSink
{
	private IMessageSink _replySink; //Field offset: 0x10
	private ServerIdentity _identity; //Field offset: 0x18

	public ServerObjectReplySink(ServerIdentity identity, IMessageSink replySink) { }

	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	public override IMessage SyncProcessMessage(IMessage msg) { }

}

