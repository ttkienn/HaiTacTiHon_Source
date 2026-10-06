namespace UnityEngine.Video;

[NativeHeader("Modules/Video/Public/VideoPlayer.h")]
[RequireComponent(typeof(Transform))]
[RequiredByNativeCode]
public sealed class VideoPlayer : Behaviour
{
	internal sealed class ErrorEventHandler : MulticastDelegate
	{

		public ErrorEventHandler(object object, IntPtr method) { }

		public override void Invoke(VideoPlayer source, string message) { }

	}

	internal sealed class EventHandler : MulticastDelegate
	{

		public EventHandler(object object, IntPtr method) { }

		public override void Invoke(VideoPlayer source) { }

	}

	internal sealed class FrameReadyEventHandler : MulticastDelegate
	{

		public FrameReadyEventHandler(object object, IntPtr method) { }

		public override void Invoke(VideoPlayer source, long frameIdx) { }

	}

	internal sealed class TimeEventHandler : MulticastDelegate
	{

		public TimeEventHandler(object object, IntPtr method) { }

		public override void Invoke(VideoPlayer source, double seconds) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler prepareCompleted; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler loopPointReached; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler started; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler frameDropped; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ErrorEventHandler errorReceived; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler seekCompleted; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TimeEventHandler clockResyncOccurred; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private FrameReadyEventHandler frameReady; //Field offset: 0x50

	[RequiredByNativeCode]
	private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds) { }

	[RequiredByNativeCode]
	private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr) { }

	[RequiredByNativeCode]
	private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx) { }

	[RequiredByNativeCode]
	private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	private static void InvokeStartedCallback_Internal(VideoPlayer source) { }

}

