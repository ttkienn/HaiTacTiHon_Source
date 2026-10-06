namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/CertificateHandler/CertificateHandlerScript.h")]
public class CertificateHandler
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public override void Dispose() { }

	[NativeMethod(IsThreadSafe = True)]
	private void Release() { }

	protected override bool ValidateCertificate(Byte[] certificateData) { }

	[RequiredByNativeCode]
	internal bool ValidateCertificateNative(Byte[] certificateData) { }

}

