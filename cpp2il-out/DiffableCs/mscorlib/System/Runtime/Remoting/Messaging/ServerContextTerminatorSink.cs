namespace System.Runtime.Remoting.Messaging;

internal class ServerContextTerminatorSink : IMessageSink
{

	public ServerContextTerminatorSink() { }

	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	public override IMessage SyncProcessMessage(IMessage msg) { }

}

