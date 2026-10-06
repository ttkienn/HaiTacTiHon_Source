namespace System.Numerics;

[Intrinsic]
public static class Vector
{

	public static bool IsHardwareAccelerated
	{
		[Intrinsic]
		 get { } //Length: 3
	}

	[CLSCompliant(False)]
	public static Vector<UInt64> AsVectorUInt64(Vector<T> value) { }

	public static Vector<T> Equals(Vector<T> left, Vector<T> right) { }

	[Intrinsic]
	public static bool get_IsHardwareAccelerated() { }

}

