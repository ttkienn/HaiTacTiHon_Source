namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeType("Runtime/Math/Vector2Int.h")]
[UsedByNativeCode]
public struct Vector2Int : IEquatable<Vector2Int>, IFormattable
{
	private static readonly Vector2Int s_Zero; //Field offset: 0x0
	private static readonly Vector2Int s_One; //Field offset: 0x8
	private static readonly Vector2Int s_Up; //Field offset: 0x10
	private static readonly Vector2Int s_Down; //Field offset: 0x18
	private static readonly Vector2Int s_Left; //Field offset: 0x20
	private static readonly Vector2Int s_Right; //Field offset: 0x28
	private int m_X; //Field offset: 0x0
	private int m_Y; //Field offset: 0x4

	public int x
	{
		 get { } //Length: 5
		 set { } //Length: 3
	}

	public int y
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	private static Vector2Int() { }

	public Vector2Int(int x, int y) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(Vector2Int other) { }

	public static Vector2Int FloorToInt(Vector2 v) { }

	public int get_x() { }

	public int get_y() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(Vector2Int lhs, Vector2Int rhs) { }

	public static Vector2 op_Implicit(Vector2Int v) { }

	public void set_x(int value) { }

	public void set_y(int value) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

