namespace System.Runtime.Remoting.Messaging;

internal class StackBuilderSink : IMessageSink
{
	private MarshalByRefObject _target; //Field offset: 0x10
	private RealProxy _rp; //Field offset: 0x18

	public StackBuilderSink(MarshalByRefObject obj, bool forceInternalExecute) { }

	[CompilerGenerated]
	private void <AsyncProcessMessage>b__4_0(object data) { }

	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	private void CheckParameters(IMessage msg) { }

	private void ExecuteAsyncMessage(object ob) { }

	public override IMessage SyncProcessMessage(IMessage msg) { }

}

