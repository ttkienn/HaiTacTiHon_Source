namespace System.Threading;

public static class Interlocked
{

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int Add(ref int location1, int value) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int CompareExchange(ref int location1, int value, int comparand) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	private static void CompareExchange(ref object location1, ref object value, ref object comparand, ref object result) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static object CompareExchange(ref object location1, object value, object comparand) { }

	public static float CompareExchange(ref float location1, float value, float comparand) { }

	[ComVisible(False)]
	[Intrinsic]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static T CompareExchange(ref T location1, T value, T comparand) { }

	public static long CompareExchange(ref long location1, long value, long comparand) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand) { }

	public static double CompareExchange(ref double location1, double value, double comparand) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int Decrement(ref int location) { }

	[ComVisible(False)]
	[Intrinsic]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static T Exchange(ref T location1, T value) { }

	public static double Exchange(ref double location1, double value) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static IntPtr Exchange(ref IntPtr location1, IntPtr value) { }

	public static long Exchange(ref long location1, long value) { }

	public static float Exchange(ref float location1, float value) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	private static void Exchange(ref object location1, ref object value, ref object result) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int Exchange(ref int location1, int value) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static object Exchange(ref object location1, object value) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static long Increment(ref long location) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int Increment(ref int location) { }

	public static void MemoryBarrier() { }

	public static long Read(ref long location) { }

}

