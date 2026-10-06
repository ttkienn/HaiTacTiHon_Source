namespace UnityEngine;

[NativeClass("Rectf", "template<typename T> class RectT; typedef RectT<float> Rectf;")]
[NativeHeader("Runtime/Math/Rect.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct Rect : IEquatable<Rect>, IFormattable
{
	[NativeName("x")]
	private float m_XMin; //Field offset: 0x0
	[NativeName("y")]
	private float m_YMin; //Field offset: 0x4
	[NativeName("width")]
	private float m_Width; //Field offset: 0x8
	[NativeName("height")]
	private float m_Height; //Field offset: 0xC

	public Vector2 center
	{
		 get { } //Length: 46
		 set { } //Length: 61
	}

	public float height
	{
		 get { } //Length: 8
		 set { } //Length: 6
	}

	public Vector2 max
	{
		 get { } //Length: 30
		 set { } //Length: 37
	}

	public Vector2 min
	{
		 get { } //Length: 20
		 set { } //Length: 64
	}

	public Vector2 position
	{
		 get { } //Length: 18
		 set { } //Length: 27
	}

	public Vector2 size
	{
		 get { } //Length: 19
		 set { } //Length: 28
	}

	public float width
	{
		 get { } //Length: 8
		 set { } //Length: 6
	}

	public float x
	{
		 get { } //Length: 7
		 set { } //Length: 5
	}

	public float xMax
	{
		 get { } //Length: 12
		 set { } //Length: 10
	}

	public float xMin
	{
		 get { } //Length: 7
		 set { } //Length: 25
	}

	public float y
	{
		 get { } //Length: 8
		 set { } //Length: 6
	}

	public float yMax
	{
		 get { } //Length: 13
		 set { } //Length: 11
	}

	public float yMin
	{
		 get { } //Length: 8
		 set { } //Length: 27
	}

	public static Rect zero
	{
		 get { } //Length: 13
	}

	public Rect(float x, float y, float width, float height) { }

	public Rect(Vector2 position, Vector2 size) { }

	public Rect(Rect source) { }

	public bool Contains(Vector3 point) { }

	public bool Contains(Vector2 point) { }

	public override bool Equals(Rect other) { }

	public virtual bool Equals(object other) { }

	public Vector2 get_center() { }

	public float get_height() { }

	public Vector2 get_max() { }

	public Vector2 get_min() { }

	public Vector2 get_position() { }

	public Vector2 get_size() { }

	public float get_width() { }

	public float get_x() { }

	public float get_xMax() { }

	public float get_xMin() { }

	public float get_y() { }

	public float get_yMax() { }

	public float get_yMin() { }

	public static Rect get_zero() { }

	public virtual int GetHashCode() { }

	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	public static bool op_Equality(Rect lhs, Rect rhs) { }

	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	private static Rect OrderMinMax(Rect rect) { }

	public bool Overlaps(Rect other, bool allowInverse) { }

	public bool Overlaps(Rect other) { }

	public void set_center(Vector2 value) { }

	public void set_height(float value) { }

	public void set_max(Vector2 value) { }

	public void set_min(Vector2 value) { }

	public void set_position(Vector2 value) { }

	public void set_size(Vector2 value) { }

	public void set_width(float value) { }

	public void set_x(float value) { }

	public void set_xMax(float value) { }

	public void set_xMin(float value) { }

	public void set_y(float value) { }

	public void set_yMax(float value) { }

	public void set_yMin(float value) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

