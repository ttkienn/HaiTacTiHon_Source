namespace UnityEngine.Windows.WebCam;

[MovedFrom("UnityEngine.XR.WSA.WebCam")]
[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
[NativeHeader("PlatformDependent/Win/Webcam/PhotoCaptureFrame.h")]
public sealed class PhotoCaptureFrame : IDisposable
{
	private IntPtr m_NativePtr; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <dataLength>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <hasLocationData>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private CapturePixelFormat <pixelFormat>k__BackingField; //Field offset: 0x20

	public private int dataLength
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private bool hasLocationData
	{
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private CapturePixelFormat pixelFormat
	{
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal PhotoCaptureFrame(IntPtr nativePtr) { }

	private void Cleanup() { }

	public override void Dispose() { }

	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeName("Dispose")]
	[ThreadAndSerializationSafe]
	private void Dispose_Internal() { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	public int get_dataLength() { }

	[ThreadAndSerializationSafe]
	private CapturePixelFormat GetCapturePixelFormat() { }

	[ThreadAndSerializationSafe]
	private int GetDataLength() { }

	[ThreadAndSerializationSafe]
	private bool GetHasLocationData() { }

	[CompilerGenerated]
	private void set_dataLength(int value) { }

	[CompilerGenerated]
	private void set_hasLocationData(bool value) { }

	[CompilerGenerated]
	private void set_pixelFormat(CapturePixelFormat value) { }

}

