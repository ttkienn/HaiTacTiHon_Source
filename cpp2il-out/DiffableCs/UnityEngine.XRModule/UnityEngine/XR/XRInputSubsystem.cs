namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystem.h")]
[UsedByNativeCode]
public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<XRInputSubsystem> trackingOriginUpdated; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<XRInputSubsystem> boundaryChanged; //Field offset: 0x28

	public XRInputSubsystem() { }

	[RequiredByNativeCode(GenerateProxy = True)]
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

	[RequiredByNativeCode(GenerateProxy = True)]
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

}

