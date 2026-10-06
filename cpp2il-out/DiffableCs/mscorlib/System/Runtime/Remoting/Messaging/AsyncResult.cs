namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem
{
	private object async_state; //Field offset: 0x10
	private WaitHandle handle; //Field offset: 0x18
	private object async_delegate; //Field offset: 0x20
	private IntPtr data; //Field offset: 0x28
	private object object_data; //Field offset: 0x30
	private bool sync_completed; //Field offset: 0x38
	private bool completed; //Field offset: 0x39
	private bool endinvoke_called; //Field offset: 0x3A
	private object async_callback; //Field offset: 0x40
	private ExecutionContext current; //Field offset: 0x48
	private ExecutionContext original; //Field offset: 0x50
	private long add_time; //Field offset: 0x58
	private MonoMethodMessage call_message; //Field offset: 0x60
	private IMessageCtrl message_ctrl; //Field offset: 0x68
	private IMessage reply_message; //Field offset: 0x70
	private WaitCallback orig_cb; //Field offset: 0x78

	public override object AsyncDelegate
	{
		 get { } //Length: 5
	}

	public override object AsyncState
	{
		 get { } //Length: 5
	}

	public override WaitHandle AsyncWaitHandle
	{
		 get { } //Length: 235
	}

	internal MonoMethodMessage CallMessage
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	public override bool CompletedSynchronously
	{
		 get { } //Length: 5
	}

	public bool EndInvokeCalled
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public override bool IsCompleted
	{
		 get { } //Length: 5
	}

	public override IMessageSink NextSink
	{
		 get { } //Length: 3
	}

	internal AsyncResult() { }

	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	internal IMessage EndInvoke() { }

	public override object get_AsyncDelegate() { }

	public override object get_AsyncState() { }

	public override WaitHandle get_AsyncWaitHandle() { }

	internal MonoMethodMessage get_CallMessage() { }

	public override bool get_CompletedSynchronously() { }

	public bool get_EndInvokeCalled() { }

	public override bool get_IsCompleted() { }

	public override IMessageSink get_NextSink() { }

	public override IMessage GetReplyMessage() { }

	internal object Invoke() { }

	internal void set_CallMessage(MonoMethodMessage value) { }

	public void set_EndInvokeCalled(bool value) { }

	internal void SetCompletedSynchronously(bool completed) { }

	public override void SetMessageCtrl(IMessageCtrl mc) { }

	public override IMessage SyncProcessMessage(IMessage msg) { }

	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	private override void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

}

