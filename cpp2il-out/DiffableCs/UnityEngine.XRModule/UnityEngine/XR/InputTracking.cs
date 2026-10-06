namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputTrackingFacade.h")]
[RequiredByNativeCode]
[StaticAccessor("XRInputTrackingFacade::Get()", StaticAccessorType::Dot (0))]
public static class InputTracking
{
	private enum TrackingStateEventType
	{
		NodeAdded = 0,
		NodeRemoved = 1,
		TrackingAcquired = 2,
		TrackingLost = 3,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<XRNodeState> trackingAcquired; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<XRNodeState> trackingLost; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<XRNodeState> nodeAdded; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<XRNodeState> nodeRemoved; //Field offset: 0x18

	[RequiredByNativeCode]
	private static void InvokeTrackingEvent(TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked) { }

}

