namespace UnityEngine.UIElements;

public interface IKeyboardEvent
{

	public char character
	{
		 get { } //Length: 0
	}

	public KeyCode keyCode
	{
		 get { } //Length: 0
	}

	public EventModifiers modifiers
	{
		 get { } //Length: 0
	}

	public char get_character() { }

	public KeyCode get_keyCode() { }

	public EventModifiers get_modifiers() { }

}

