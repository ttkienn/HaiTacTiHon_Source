namespace UnityEngine.TextCore.LowLevel;

[UsedByNativeCode]
internal struct GlyphAnchorPoint
{
	[NativeName("xPositionAdjustment")]
	[SerializeField]
	private float m_XCoordinate; //Field offset: 0x0
	[NativeName("yPositionAdjustment")]
	[SerializeField]
	private float m_YCoordinate; //Field offset: 0x4

	public float xCoordinate
	{
		 get { } //Length: 7
	}

	public float yCoordinate
	{
		 get { } //Length: 8
	}

	public float get_xCoordinate() { }

	public float get_yCoordinate() { }

}

