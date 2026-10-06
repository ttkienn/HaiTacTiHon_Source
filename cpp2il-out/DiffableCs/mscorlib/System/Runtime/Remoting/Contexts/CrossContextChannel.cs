namespace System.Runtime.Remoting.Contexts;

internal class CrossContextChannel : IMessageSink
{
	private class ContextRestoreSink : IMessageSink
	{
		private IMessageSink _next; //Field offset: 0x10
		private Context _context; //Field offset: 0x18
		private IMessage _call; //Field offset: 0x20

		public ContextRestoreSink(IMessageSink next, Context context, IMessage call) { }

		public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

		public override IMessage SyncProcessMessage(IMessage msg) { }

	}


	public CrossContextChannel() { }

	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	public override IMessage SyncProcessMessage(IMessage msg) { }

}

