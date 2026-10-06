namespace UnityEngine;

[VisibleToOtherModules]
internal class SystemClock
{
	private static readonly DateTime s_Epoch; //Field offset: 0x0

	public static DateTime now
	{
		 get { } //Length: 64
	}

	private static SystemClock() { }

	public static DateTime get_now() { }

}

