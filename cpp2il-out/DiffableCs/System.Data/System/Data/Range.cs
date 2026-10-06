namespace System.Data;

internal struct Range
{
	private int _min; //Field offset: 0x0
	private int _max; //Field offset: 0x4
	private bool _isNotNull; //Field offset: 0x8

	public int Count
	{
		 get { } //Length: 17
	}

	public bool IsNull
	{
		 get { } //Length: 8
	}

	public int Min
	{
		 get { } //Length: 60
	}

	public Range(int min, int max) { }

	internal void CheckNull() { }

	public int get_Count() { }

	public bool get_IsNull() { }

	public int get_Min() { }

}

