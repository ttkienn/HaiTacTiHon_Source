namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[UsedByNativeCode]
public struct InputDevice : IEquatable<InputDevice>
{
	private ulong m_DeviceId; //Field offset: 0x0
	private bool m_Initialized; //Field offset: 0x8

	private ulong deviceId
	{
		private get { } //Length: 18
	}

	internal InputDevice(ulong deviceId) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(InputDevice other) { }

	private ulong get_deviceId() { }

	public virtual int GetHashCode() { }

}

