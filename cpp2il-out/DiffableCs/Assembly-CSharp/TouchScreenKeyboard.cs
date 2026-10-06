//Type is in global namespace

public class TouchScreenKeyboard
{
	public static bool hideInput; //Field offset: 0x0
	public static bool visible; //Field offset: 0x1
	public bool done; //Field offset: 0x10
	public bool active; //Field offset: 0x11
	public string text; //Field offset: 0x18

	public TouchScreenKeyboard() { }

	public static void Clear() { }

	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType t, bool b1, bool b2, bool type, bool b3, string caption) { }

}

