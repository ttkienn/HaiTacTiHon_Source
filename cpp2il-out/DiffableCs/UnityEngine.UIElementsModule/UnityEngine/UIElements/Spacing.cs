namespace UnityEngine.UIElements;

internal struct Spacing
{
	public float left; //Field offset: 0x0
	public float top; //Field offset: 0x4
	public float right; //Field offset: 0x8
	public float bottom; //Field offset: 0xC

	public float horizontal
	{
		 get { } //Length: 12
	}

	public float vertical
	{
		 get { } //Length: 13
	}

	public Spacing(float left, float top, float right, float bottom) { }

	public float get_horizontal() { }

	public float get_vertical() { }

	public static Rect op_Subtraction(Rect r, Spacing a) { }

}

