namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[RequiredByNativeCode]
public struct InputFeatureUsage : IEquatable<InputFeatureUsage>
{
	internal string m_Name; //Field offset: 0x0
	[NativeName("m_FeatureType")]
	internal InputFeatureType m_InternalType; //Field offset: 0x8

	internal InputFeatureType internalType
	{
		internal get { } //Length: 6
	}

	public string name
	{
		 get { } //Length: 6
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(InputFeatureUsage other) { }

	internal InputFeatureType get_internalType() { }

	public string get_name() { }

	public virtual int GetHashCode() { }

}

