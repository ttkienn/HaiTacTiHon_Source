//Type is in global namespace

public class ScaleGUI
{
	public static bool scaleScreen; //Field offset: 0x0
	public static float WIDTH; //Field offset: 0x4
	public static float HEIGHT; //Field offset: 0x8
	private static List<Matrix4x4> stack; //Field offset: 0x10

	private static ScaleGUI() { }

	public ScaleGUI() { }

	public static void BeginGUI() { }

	public static void EndGUI() { }

	public static void initScaleGUI() { }

	public static float scaleX(float x) { }

	public static float scaleY(float y) { }

}

