namespace UnityEngine.Experimental.GlobalIllumination;

public struct LinearColor
{
	private float m_red; //Field offset: 0x0
	private float m_green; //Field offset: 0x4
	private float m_blue; //Field offset: 0x8
	private float m_intensity; //Field offset: 0xC

	public float blue
	{
		 get { } //Length: 8
		 set { } //Length: 186
	}

	public float green
	{
		 get { } //Length: 8
		 set { } //Length: 186
	}

	public float red
	{
		 get { } //Length: 7
		 set { } //Length: 185
	}

	public static LinearColor Black() { }

	public static LinearColor Convert(Color color, float intensity) { }

	public float get_blue() { }

	public float get_green() { }

	public float get_red() { }

	public void set_blue(float value) { }

	public void set_green(float value) { }

	public void set_red(float value) { }

}

