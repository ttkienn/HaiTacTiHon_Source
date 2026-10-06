namespace System.Numerics;

[DefaultMember("Item")]
[Intrinsic]
public struct Vector : IEquatable<Vector`1<T>>, IFormattable
{
	private struct VectorSizeHelper
	{
		internal Vector<T> _placeholder; //Field offset: 0x0
		internal byte _byte; //Field offset: 0x0

	}

	private static readonly int s_count; //Field offset: 0x0
	private static readonly Vector<T> s_zero; //Field offset: 0x0
	private static readonly Vector<T> s_one; //Field offset: 0x0
	private static readonly Vector<T> s_allOnes; //Field offset: 0x0
	private Register register; //Field offset: 0x0

	public static int Count
	{
		[Intrinsic]
		 get { } //Length: 151
	}

	public T Item
	{
		[Intrinsic]
		 get { } //Length: 2894
	}

	public static Vector<T> Zero
	{
		[Intrinsic]
		 get { } //Length: 159
	}

	private static Vector`1() { }

	[Intrinsic]
	public Vector`1(T value) { }

	internal Vector`1(Void* dataPointer) { }

	internal Vector`1(Void* dataPointer, int offset) { }

	private Vector`1(ref Register existingRegister) { }

	[Intrinsic]
	internal static Vector<T> Equals(Vector<T> left, Vector<T> right) { }

	[Intrinsic]
	public override bool Equals(Vector<T> other) { }

	public virtual bool Equals(object obj) { }

	[Intrinsic]
	public static int get_Count() { }

	[Intrinsic]
	public T get_Item(int index) { }

	[Intrinsic]
	public static Vector<T> get_Zero() { }

	private static T GetAllBitsSetValue() { }

	public virtual int GetHashCode() { }

	private static T GetOneValue() { }

	private static int InitializeCount() { }

	public static bool op_Equality(Vector<T> left, Vector<T> right) { }

	[CLSCompliant(False)]
	[Intrinsic]
	public static Vector<UInt64> op_Explicit(Vector<T> value) { }

	public static bool op_Inequality(Vector<T> left, Vector<T> right) { }

	private static bool ScalarEquals(T left, T right) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

