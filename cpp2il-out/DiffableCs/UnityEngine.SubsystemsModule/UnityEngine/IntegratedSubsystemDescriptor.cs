namespace UnityEngine;

[UsedByNativeCode("SubsystemDescriptorBase")]
public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptor
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public override string id
	{
		 get { } //Length: 52
	}

	protected IntegratedSubsystemDescriptor() { }

	public override string get_id() { }

}

