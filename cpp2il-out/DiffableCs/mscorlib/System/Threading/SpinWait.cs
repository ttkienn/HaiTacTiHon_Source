namespace System.Threading;

public struct SpinWait
{
	internal static readonly int SpinCountforSpinBeforeWait; //Field offset: 0x0
	private int _count; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 3
	}

	public bool NextSpinWillYield
	{
		 get { } //Length: 98
	}

	private static SpinWait() { }

	public int get_Count() { }

	public bool get_NextSpinWillYield() { }

	public void SpinOnce() { }

	public void SpinOnce(int sleep1Threshold) { }

	private void SpinOnceCore(int sleep1Threshold) { }

}

