namespace System.Runtime.Remoting.Channels;

[MonoTODO("Handle domain unloading?")]
internal class CrossAppDomainSink : IMessageSink
{
	private struct ProcessMessageRes
	{
		public Byte[] arrResponse; //Field offset: 0x0
		public CADMethodReturnMessage cadMrm; //Field offset: 0x8

	}

	private static Hashtable s_sinks; //Field offset: 0x0
	private static MethodInfo processMessageMethod; //Field offset: 0x8
	private int _domainID; //Field offset: 0x10

	internal int TargetDomainId
	{
		internal get { } //Length: 191
	}

	private static CrossAppDomainSink() { }

	internal CrossAppDomainSink(int domainID) { }

	[CompilerGenerated]
	private void <AsyncProcessMessage>b__10_0(object data) { }

	public override IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink) { }

	internal int get_TargetDomainId() { }

	internal static CrossAppDomainSink GetSink(int domainID) { }

	private static ProcessMessageRes ProcessMessageInDomain(Byte[] arrRequest, CADMethodCallMessage cadMsg) { }

	public void SendAsyncMessage(object data) { }

	public override IMessage SyncProcessMessage(IMessage msgRequest) { }

}

