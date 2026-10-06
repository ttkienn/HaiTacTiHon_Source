namespace System.Runtime.Remoting.Lifetime;

internal class LeaseSink : IMessageSink
{
	private IMessageSink _nextSink; //Field offset: 0x10

	public LeaseSink(IMessageSink nextSink) { }

	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	private void RenewLease(IMessage msg) { }

	public override IMessage SyncProcessMessage(IMessage msg) { }

}

