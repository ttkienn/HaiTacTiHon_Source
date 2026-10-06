namespace UnityEngine;

[NativeHeader("Runtime/Input/InputBindings.h")]
public struct Touch
{
	private int m_FingerId; //Field offset: 0x0
	private Vector2 m_Position; //Field offset: 0x4
	private Vector2 m_RawPosition; //Field offset: 0xC
	private Vector2 m_PositionDelta; //Field offset: 0x14
	private float m_TimeDelta; //Field offset: 0x1C
	private int m_TapCount; //Field offset: 0x20
	private TouchPhase m_Phase; //Field offset: 0x24
	private TouchType m_Type; //Field offset: 0x28
	private float m_Pressure; //Field offset: 0x2C
	private float m_maximumPossiblePressure; //Field offset: 0x30
	private float m_Radius; //Field offset: 0x34
	private float m_RadiusVariance; //Field offset: 0x38
	private float m_AltitudeAngle; //Field offset: 0x3C
	private float m_AzimuthAngle; //Field offset: 0x40

	public float altitudeAngle
	{
		 get { } //Length: 8
	}

	public float azimuthAngle
	{
		 get { } //Length: 8
	}

	public Vector2 deltaPosition
	{
		 get { } //Length: 19
		 set { } //Length: 5
	}

	public float deltaTime
	{
		 get { } //Length: 8
	}

	public int fingerId
	{
		 get { } //Length: 5
	}

	public float maximumPossiblePressure
	{
		 get { } //Length: 8
	}

	public TouchPhase phase
	{
		 get { } //Length: 6
	}

	public Vector2 position
	{
		 get { } //Length: 19
		 set { } //Length: 5
	}

	public float pressure
	{
		 get { } //Length: 8
	}

	public float radius
	{
		 get { } //Length: 8
	}

	public float radiusVariance
	{
		 get { } //Length: 8
	}

	public Vector2 rawPosition
	{
		 get { } //Length: 19
		 set { } //Length: 5
	}

	public int tapCount
	{
		 get { } //Length: 6
	}

	public TouchType type
	{
		 get { } //Length: 1817
	}

	public float get_altitudeAngle() { }

	public float get_azimuthAngle() { }

	public Vector2 get_deltaPosition() { }

	public float get_deltaTime() { }

	public int get_fingerId() { }

	public float get_maximumPossiblePressure() { }

	public TouchPhase get_phase() { }

	public Vector2 get_position() { }

	public float get_pressure() { }

	public float get_radius() { }

	public float get_radiusVariance() { }

	public Vector2 get_rawPosition() { }

	public int get_tapCount() { }

	public TouchType get_type() { }

	public void set_deltaPosition(Vector2 value) { }

	public void set_position(Vector2 value) { }

	public void set_rawPosition(Vector2 value) { }

}

