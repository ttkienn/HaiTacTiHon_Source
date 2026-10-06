namespace System.IO;

internal class FileStreamAsyncResult : IAsyncResult
{
	private object state; //Field offset: 0x10
	private bool completed; //Field offset: 0x18
	private ManualResetEvent wh; //Field offset: 0x20
	private AsyncCallback cb; //Field offset: 0x28
	private bool completedSynch; //Field offset: 0x30
	public int Count; //Field offset: 0x34
	public int OriginalCount; //Field offset: 0x38
	public int BytesRead; //Field offset: 0x3C
	private AsyncCallback realcb; //Field offset: 0x40

	public override object AsyncState
	{
		 get { } //Length: 5
	}

	public override WaitHandle AsyncWaitHandle
	{
		 get { } //Length: 5
	}

	public override bool CompletedSynchronously
	{
		 get { } //Length: 5
	}

	public override bool IsCompleted
	{
		 get { } //Length: 5
	}

	public FileStreamAsyncResult(AsyncCallback cb, object state) { }

	private static void CBWrapper(IAsyncResult ares) { }

	public override object get_AsyncState() { }

	public override WaitHandle get_AsyncWaitHandle() { }

	public override bool get_CompletedSynchronously() { }

	public override bool get_IsCompleted() { }

}

