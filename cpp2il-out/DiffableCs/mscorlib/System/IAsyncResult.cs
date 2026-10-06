namespace System;

public interface IAsyncResult
{

	public object AsyncState
	{
		 get { } //Length: 0
	}

	public WaitHandle AsyncWaitHandle
	{
		 get { } //Length: 0
	}

	public bool CompletedSynchronously
	{
		 get { } //Length: 0
	}

	public bool IsCompleted
	{
		 get { } //Length: 0
	}

	public object get_AsyncState() { }

	public WaitHandle get_AsyncWaitHandle() { }

	public bool get_CompletedSynchronously() { }

	public bool get_IsCompleted() { }

}

