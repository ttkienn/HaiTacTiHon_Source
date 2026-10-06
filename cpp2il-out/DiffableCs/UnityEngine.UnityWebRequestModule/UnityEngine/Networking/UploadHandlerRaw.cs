namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandlerRaw.h")]
public sealed class UploadHandlerRaw : UploadHandler
{
	private NativeArray<Byte> m_Payload; //Field offset: 0x18

	public UploadHandlerRaw(Byte[] data) { }

	public UploadHandlerRaw(NativeArray<Byte> data, bool transferOwnership) { }

	private static IntPtr Create(UploadHandlerRaw self, Byte* data, int dataLength) { }

	public virtual void Dispose() { }

}

