namespace System.Data;

internal abstract class AutoIncrementValue
{
	[CompilerGenerated]
	private bool <Auto>k__BackingField; //Field offset: 0x10

	internal bool Auto
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal abstract object Current
	{
		internal get { } //Length: 0
		internal set { } //Length: 0
	}

	internal abstract Type DataType
	{
		internal get { } //Length: 0
	}

	internal abstract long Seed
	{
		internal get { } //Length: 0
		internal set { } //Length: 0
	}

	internal abstract long Step
	{
		internal get { } //Length: 0
		internal set { } //Length: 0
	}

	protected AutoIncrementValue() { }

	internal AutoIncrementValue Clone() { }

	[CompilerGenerated]
	internal bool get_Auto() { }

	internal abstract object get_Current() { }

	internal abstract Type get_DataType() { }

	internal abstract long get_Seed() { }

	internal abstract long get_Step() { }

	internal abstract void MoveAfter() { }

	[CompilerGenerated]
	internal void set_Auto(bool value) { }

	internal abstract void set_Current(object value) { }

	internal abstract void set_Seed(long value) { }

	internal abstract void set_Step(long value) { }

	internal abstract void SetCurrent(object value, IFormatProvider formatProvider) { }

	internal abstract void SetCurrentAndIncrement(object value) { }

}

