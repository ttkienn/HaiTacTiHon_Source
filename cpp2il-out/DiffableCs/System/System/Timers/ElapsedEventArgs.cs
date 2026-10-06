namespace System.Timers;

public class ElapsedEventArgs : EventArgs
{
	private DateTime time; //Field offset: 0x10

	internal ElapsedEventArgs(DateTime time) { }

}

