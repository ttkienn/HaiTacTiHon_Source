namespace UnityEngine.UIElements;

public interface IPointerEvent
{

	public bool actionKey
	{
		 get { } //Length: 0
	}

	public float altitudeAngle
	{
		 get { } //Length: 0
	}

	public bool altKey
	{
		 get { } //Length: 0
	}

	public float azimuthAngle
	{
		 get { } //Length: 0
	}

	public int button
	{
		 get { } //Length: 0
	}

	public int clickCount
	{
		 get { } //Length: 0
	}

	public bool commandKey
	{
		 get { } //Length: 0
	}

	public bool ctrlKey
	{
		 get { } //Length: 0
	}

	public Vector3 deltaPosition
	{
		 get { } //Length: 0
	}

	public float deltaTime
	{
		 get { } //Length: 0
	}

	public bool isPrimary
	{
		 get { } //Length: 0
	}

	public Vector3 localPosition
	{
		 get { } //Length: 0
	}

	public EventModifiers modifiers
	{
		 get { } //Length: 0
	}

	public PenStatus penStatus
	{
		 get { } //Length: 0
	}

	public int pointerId
	{
		 get { } //Length: 0
	}

	public string pointerType
	{
		 get { } //Length: 0
	}

	public Vector3 position
	{
		 get { } //Length: 0
	}

	public int pressedButtons
	{
		 get { } //Length: 0
	}

	public float pressure
	{
		 get { } //Length: 0
	}

	public Vector2 radius
	{
		 get { } //Length: 0
	}

	public Vector2 radiusVariance
	{
		 get { } //Length: 0
	}

	public bool shiftKey
	{
		 get { } //Length: 0
	}

	public float tangentialPressure
	{
		 get { } //Length: 0
	}

	public Vector2 tilt
	{
		 get { } //Length: 0
	}

	public float twist
	{
		 get { } //Length: 0
	}

	public bool get_actionKey() { }

	public float get_altitudeAngle() { }

	public bool get_altKey() { }

	public float get_azimuthAngle() { }

	public int get_button() { }

	public int get_clickCount() { }

	public bool get_commandKey() { }

	public bool get_ctrlKey() { }

	public Vector3 get_deltaPosition() { }

	public float get_deltaTime() { }

	public bool get_isPrimary() { }

	public Vector3 get_localPosition() { }

	public EventModifiers get_modifiers() { }

	public PenStatus get_penStatus() { }

	public int get_pointerId() { }

	public string get_pointerType() { }

	public Vector3 get_position() { }

	public int get_pressedButtons() { }

	public float get_pressure() { }

	public Vector2 get_radius() { }

	public Vector2 get_radiusVariance() { }

	public bool get_shiftKey() { }

	public float get_tangentialPressure() { }

	public Vector2 get_tilt() { }

	public float get_twist() { }

}

