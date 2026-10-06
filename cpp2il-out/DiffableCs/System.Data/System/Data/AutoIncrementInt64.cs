namespace System.Data;

internal sealed class AutoIncrementInt64 : AutoIncrementValue
{
	private long _current; //Field offset: 0x18
	private long _seed; //Field offset: 0x20
	private long _step; //Field offset: 0x28

	internal virtual object Current
	{
		internal get { } //Length: 69
		internal set { } //Length: 109
	}

	internal virtual Type DataType
	{
		internal get { } //Length: 89
	}

	internal virtual long Seed
	{
		internal get { } //Length: 5
		internal set { } //Length: 138
	}

	internal virtual long Step
	{
		internal get { } //Length: 5
		internal set { } //Length: 128
	}

	public AutoIncrementInt64() { }

	private bool BoundaryCheck(BigInteger value) { }

	internal virtual object get_Current() { }

	internal virtual Type get_DataType() { }

	internal virtual long get_Seed() { }

	internal virtual long get_Step() { }

	internal virtual void MoveAfter() { }

	internal virtual void set_Current(object value) { }

	internal virtual void set_Seed(long value) { }

	internal virtual void set_Step(long value) { }

	internal virtual void SetCurrent(object value, IFormatProvider formatProvider) { }

	internal virtual void SetCurrentAndIncrement(object value) { }

}

