namespace System.Runtime.Remoting.Messaging;

internal class ClientContextTerminatorSink : IMessageSink
{
	private Context _context; //Field offset: 0x10

	public ClientContextTerminatorSink(Context ctx) { }

	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	public override IMessage SyncProcessMessage(IMessage msg) { }

}

