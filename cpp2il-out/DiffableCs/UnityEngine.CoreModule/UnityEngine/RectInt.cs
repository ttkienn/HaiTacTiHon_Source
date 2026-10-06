namespace UnityEngine;

[UsedByNativeCode]
public struct RectInt : IEquatable<RectInt>, IFormattable
{
	private int m_XMin; //Field offset: 0x0
	private int m_YMin; //Field offset: 0x4
	private int m_Width; //Field offset: 0x8
	private int m_Height; //Field offset: 0xC

	public int height
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public int width
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public int x
	{
		 get { } //Length: 5
		 set { } //Length: 3
	}

	public int xMax
	{
		 get { } //Length: 100
	}

	public int xMin
	{
		 get { } //Length: 100
	}

	public int y
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public int yMax
	{
		 get { } //Length: 101
	}

	public int yMin
	{
		 get { } //Length: 101
	}

	public RectInt(int xMin, int yMin, int width, int height) { }

	public override bool Equals(RectInt other) { }

	public int get_height() { }

	public int get_width() { }

	public int get_x() { }

	public int get_xMax() { }

	public int get_xMin() { }

	public int get_y() { }

	public int get_yMax() { }

	public int get_yMin() { }

	public bool Overlaps(RectInt other) { }

	public void set_height(int value) { }

	public void set_width(int value) { }

	public void set_x(int value) { }

	public void set_y(int value) { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

	public virtual string ToString() { }

}

