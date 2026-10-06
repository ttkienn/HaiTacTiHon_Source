namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystemDescriptor.h")]
[UsedByNativeCode]
public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem>
{

	public XRInputSubsystemDescriptor() { }

}

