namespace UnityEngine;

public struct LocationInfo
{
	internal double m_Timestamp; //Field offset: 0x0
	internal float m_Latitude; //Field offset: 0x8
	internal float m_Longitude; //Field offset: 0xC
	internal float m_Altitude; //Field offset: 0x10
	internal float m_HorizontalAccuracy; //Field offset: 0x14
	internal float m_VerticalAccuracy; //Field offset: 0x18

	public float latitude
	{
		 get { } //Length: 8
	}

	public float longitude
	{
		 get { } //Length: 8
	}

	public float get_latitude() { }

	public float get_longitude() { }

}

