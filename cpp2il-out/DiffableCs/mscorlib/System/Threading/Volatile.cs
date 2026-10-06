namespace System.Threading;

public static class Volatile
{
	private struct VolatileBoolean
	{
		public bool Value; //Field offset: 0x0

	}

	private struct VolatileInt32
	{
		public int Value; //Field offset: 0x0

	}

	private struct VolatileObject
	{
		public object Value; //Field offset: 0x0

	}


	[Intrinsic]
	public static bool Read(ref bool location) { }

	[Intrinsic]
	public static int Read(ref int location) { }

	[Intrinsic]
	public static T Read(ref T location) { }

	[Intrinsic]
	public static void Write(ref bool location, bool value) { }

	[Intrinsic]
	public static void Write(ref int location, int value) { }

	[Intrinsic]
	public static void Write(ref T location, T value) { }

}

