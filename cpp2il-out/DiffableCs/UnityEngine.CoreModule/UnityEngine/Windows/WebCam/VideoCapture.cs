namespace UnityEngine.Windows.WebCam;

[MovedFrom("UnityEngine.XR.WSA.WebCam")]
[NativeHeader("PlatformDependent/Win/Webcam/VideoCaptureBindings.h")]
[StaticAccessor("VideoCaptureBindings", StaticAccessorType::DoubleColon (2))]
public class VideoCapture : IDisposable
{
	internal enum CaptureResultType
	{
		Success = 0,
		UnknownError = 1,
	}

	internal sealed class OnStartedRecordingVideoCallback : MulticastDelegate
	{

		public OnStartedRecordingVideoCallback(object object, IntPtr method) { }

		public override void Invoke(VideoCaptureResult result) { }

	}

	internal sealed class OnStoppedRecordingVideoCallback : MulticastDelegate
	{

		public OnStoppedRecordingVideoCallback(object object, IntPtr method) { }

		public override void Invoke(VideoCaptureResult result) { }

	}

	internal sealed class OnVideoCaptureResourceCreatedCallback : MulticastDelegate
	{

		public OnVideoCaptureResourceCreatedCallback(object object, IntPtr method) { }

		public override void Invoke(VideoCapture captureObject) { }

	}

	internal sealed class OnVideoModeStartedCallback : MulticastDelegate
	{

		public OnVideoModeStartedCallback(object object, IntPtr method) { }

		public override void Invoke(VideoCaptureResult result) { }

	}

	internal sealed class OnVideoModeStoppedCallback : MulticastDelegate
	{

		public OnVideoModeStoppedCallback(object object, IntPtr method) { }

		public override void Invoke(VideoCaptureResult result) { }

	}

	internal struct VideoCaptureResult
	{
		public CaptureResultType resultType; //Field offset: 0x0
		public long hResult; //Field offset: 0x8

	}

	private static readonly long HR_SUCCESS; //Field offset: 0x0
	internal IntPtr m_NativePtr; //Field offset: 0x10

	private VideoCapture(IntPtr nativeCaptureObject) { }

	public override void Dispose() { }

	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeMethod("VideoCaptureBindings::Dispose", HasExplicitThis = True)]
	private void Dispose_Internal() { }

	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeMethod("VideoCaptureBindings::DisposeThreaded", HasExplicitThis = True)]
	[ThreadAndSerializationSafe]
	private void DisposeThreaded_Internal() { }

	protected virtual void Finalize() { }

	[RequiredByNativeCode]
	private static void InvokeOnCreatedVideoCaptureResourceDelegate(OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	[RequiredByNativeCode]
	private static void InvokeOnStartedRecordingVideoToDiskDelegate(OnStartedRecordingVideoCallback callback, long hResult) { }

	[RequiredByNativeCode]
	private static void InvokeOnStoppedRecordingVideoToDiskDelegate(OnStoppedRecordingVideoCallback callback, long hResult) { }

	[RequiredByNativeCode]
	private static void InvokeOnVideoModeStartedDelegate(OnVideoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCode]
	private static void InvokeOnVideoModeStoppedDelegate(OnVideoModeStoppedCallback callback, long hResult) { }

	private static VideoCaptureResult MakeCaptureResult(long hResult) { }

}

