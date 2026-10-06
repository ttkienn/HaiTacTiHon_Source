namespace UnityEngine.XR;

[UsedByNativeCode]
public struct XRNodeState
{
	private XRNode m_Type; //Field offset: 0x0
	private AvailableTrackingData m_AvailableFields; //Field offset: 0x4
	private Vector3 m_Position; //Field offset: 0x8
	private Quaternion m_Rotation; //Field offset: 0x14
	private Vector3 m_Velocity; //Field offset: 0x24
	private Vector3 m_AngularVelocity; //Field offset: 0x30
	private Vector3 m_Acceleration; //Field offset: 0x3C
	private Vector3 m_AngularAcceleration; //Field offset: 0x48
	private int m_Tracked; //Field offset: 0x54
	private ulong m_UniqueID; //Field offset: 0x58

	public XRNode nodeType
	{
		 set { } //Length: 3
	}

	public bool tracked
	{
		 set { } //Length: 9
	}

	public ulong uniqueID
	{
		 set { } //Length: 5
	}

	public void set_nodeType(XRNode value) { }

	public void set_tracked(bool value) { }

	public void set_uniqueID(ulong value) { }

}

