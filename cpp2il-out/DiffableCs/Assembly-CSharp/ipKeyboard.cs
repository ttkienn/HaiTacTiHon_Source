//Type is in global namespace

public class ipKeyboard
{
	public static TouchScreenKeyboard tk; //Field offset: 0x0
	public static int TEXT; //Field offset: 0x8
	public static int NUMBERIC; //Field offset: 0xC
	public static int PASS; //Field offset: 0x10
	private static IKAction act; //Field offset: 0x18

	private static ipKeyboard() { }

	public ipKeyboard() { }

	public static void openKeyBoard(string caption, int type, string text, IKAction action) { }

	public static void update() { }

}

