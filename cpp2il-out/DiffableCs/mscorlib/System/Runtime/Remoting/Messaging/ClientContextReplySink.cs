namespace System.Runtime.Remoting.Messaging;

internal class ClientContextReplySink : IMessageSink
{
	private IMessageSink _replySink; //Field offset: 0x10
	private Context _context; //Field offset: 0x18

	public ClientContextReplySink(Context ctx, IMessageSink replySink) { }

	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	public override IMessage SyncProcessMessage(IMessage msg) { }

}

