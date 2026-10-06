namespace System.Runtime.Remoting.Messaging;

internal class ServerObjectTerminatorSink : IMessageSink
{
	private IMessageSink _nextSink; //Field offset: 0x10

	public ServerObjectTerminatorSink(IMessageSink nextSink) { }

	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	public override IMessage SyncProcessMessage(IMessage msg) { }

}

