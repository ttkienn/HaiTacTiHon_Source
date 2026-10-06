namespace UnityEngine.UIElements;

public interface IMouseEvent
{

	public bool altKey
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

	public Vector2 localMousePosition
	{
		 get { } //Length: 0
	}

	public EventModifiers modifiers
	{
		 get { } //Length: 0
	}

	public Vector2 mouseDelta
	{
		 get { } //Length: 0
	}

	public Vector2 mousePosition
	{
		 get { } //Length: 0
	}

	public int pressedButtons
	{
		 get { } //Length: 0
	}

	public bool shiftKey
	{
		 get { } //Length: 0
	}

	public bool get_altKey() { }

	public int get_button() { }

	public int get_clickCount() { }

	public bool get_commandKey() { }

	public bool get_ctrlKey() { }

	public Vector2 get_localMousePosition() { }

	public EventModifiers get_modifiers() { }

	public Vector2 get_mouseDelta() { }

	public Vector2 get_mousePosition() { }

	public int get_pressedButtons() { }

	public bool get_shiftKey() { }

}

