namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandler.h")]
public class UploadHandler : IDisposable
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public string contentType
	{
		 set { } //Length: 20
	}

	internal UploadHandler() { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	[NativeMethod("SetContentType")]
	private void InternalSetContentType(string newContentType) { }

	[NativeMethod(IsThreadSafe = True)]
	private void Release() { }

	public void set_contentType(string value) { }

	internal override void SetContentType(string newContentType) { }

}

