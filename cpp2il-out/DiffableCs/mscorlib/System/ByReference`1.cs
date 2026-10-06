namespace System;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct ByReference
{
	private IntPtr _value; //Field offset: 0x0

	public T Value
	{
		[Intrinsic]
		 get { } //Length: 57
	}

	[Intrinsic]
	public ByReference`1(ref T value) { }

	[Intrinsic]
	public T get_Value() { }

}

