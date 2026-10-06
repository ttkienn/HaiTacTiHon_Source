namespace Unity.Services.Analytics.Internal;

internal interface IDispatcher
{

	public int ConsecutiveFailedUploadCount
	{
		 get { } //Length: 0
	}

	public void Flush() { }

	public int get_ConsecutiveFailedUploadCount() { }

	public void SetBuffer(IBuffer buffer) { }

}

