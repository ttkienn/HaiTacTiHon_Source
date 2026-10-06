namespace UnityEngine.TextCore.LowLevel;

[UsedByNativeCode]
internal struct MarkPositionAdjustment
{
	[NativeName("xCoordinate")]
	[SerializeField]
	private float m_XPositionAdjustment; //Field offset: 0x0
	[NativeName("yCoordinate")]
	[SerializeField]
	private float m_YPositionAdjustment; //Field offset: 0x4

	public float xPositionAdjustment
	{
		 get { } //Length: 7
	}

	public float yPositionAdjustment
	{
		 get { } //Length: 8
	}

	public float get_xPositionAdjustment() { }

	public float get_yPositionAdjustment() { }

}

