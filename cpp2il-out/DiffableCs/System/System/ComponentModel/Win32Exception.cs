namespace System.ComponentModel;

public class Win32Exception : ExternalException, ISerializable
{
	private readonly int nativeErrorCode; //Field offset: 0x90

	public int NativeErrorCode
	{
		 get { } //Length: 7
	}

	public Win32Exception() { }

	public Win32Exception(int error) { }

	public Win32Exception(int error, string message) { }

	protected Win32Exception(SerializationInfo info, StreamingContext context) { }

	public int get_NativeErrorCode() { }

	internal static string GetErrorMessage(int error) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

