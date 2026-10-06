namespace System.Diagnostics;

public class Stopwatch
{
	public static readonly long Frequency; //Field offset: 0x0
	public static readonly bool IsHighResolution; //Field offset: 0x8
	private long elapsed; //Field offset: 0x10
	private long started; //Field offset: 0x18
	private bool is_running; //Field offset: 0x20

	public TimeSpan Elapsed
	{
		 get { } //Length: 408
	}

	public long ElapsedMilliseconds
	{
		 get { } //Length: 739
	}

	public long ElapsedTicks
	{
		 get { } //Length: 99
	}

	public bool IsRunning
	{
		 get { } //Length: 5
	}

	private static Stopwatch() { }

	public Stopwatch() { }

	public TimeSpan get_Elapsed() { }

	public long get_ElapsedMilliseconds() { }

	public long get_ElapsedTicks() { }

	public bool get_IsRunning() { }

	public static long GetTimestamp() { }

	public void Restart() { }

	public void Start() { }

	public void Stop() { }

}

