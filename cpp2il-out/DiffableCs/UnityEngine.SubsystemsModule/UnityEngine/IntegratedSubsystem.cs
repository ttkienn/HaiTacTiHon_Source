namespace UnityEngine;

[NativeHeader("Modules/Subsystems/Subsystem.h")]
[UsedByNativeCode]
public class IntegratedSubsystem
{
	internal IntPtr m_Ptr; //Field offset: 0x10
	internal ISubsystemDescriptor m_SubsystemDescriptor; //Field offset: 0x18

	public IntegratedSubsystem() { }

	internal void SetHandle(IntegratedSubsystem subsystem) { }

}

