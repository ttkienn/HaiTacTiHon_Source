namespace UnityEngine.Yoga;

internal struct YogaValue
{
	private float value; //Field offset: 0x0
	private YogaUnit unit; //Field offset: 0x4

	public YogaUnit Unit
	{
		 get { } //Length: 6
	}

	public float Value
	{
		 get { } //Length: 7
	}

	public static YogaValue Auto() { }

	public bool Equals(YogaValue other) { }

	public virtual bool Equals(object obj) { }

	public YogaUnit get_Unit() { }

	public float get_Value() { }

	public virtual int GetHashCode() { }

	public static YogaValue op_Implicit(float pointValue) { }

	public static YogaValue Percent(float value) { }

	public static YogaValue Point(float value) { }

}

