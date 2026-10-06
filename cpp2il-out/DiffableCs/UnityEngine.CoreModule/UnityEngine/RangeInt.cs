namespace UnityEngine;

public struct RangeInt
{
	public int start; //Field offset: 0x0
	public int length; //Field offset: 0x4

	public int end
	{
		 get { } //Length: 8
	}

	public RangeInt(int start, int length) { }

	public int get_end() { }

}

