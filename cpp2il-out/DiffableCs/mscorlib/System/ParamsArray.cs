namespace System;

[DefaultMember("Item")]
[IsReadOnly]
internal struct ParamsArray
{
	private static readonly Object[] s_oneArgArray; //Field offset: 0x0
	private static readonly Object[] s_twoArgArray; //Field offset: 0x8
	private static readonly Object[] s_threeArgArray; //Field offset: 0x10
	private readonly object _arg0; //Field offset: 0x0
	private readonly object _arg1; //Field offset: 0x8
	private readonly object _arg2; //Field offset: 0x10
	private readonly Object[] _args; //Field offset: 0x18

	public object Item
	{
		 get { } //Length: 164
	}

	public int Length
	{
		 get { } //Length: 26
	}

	private static ParamsArray() { }

	public ParamsArray(object arg0) { }

	public ParamsArray(object arg0, object arg1) { }

	public ParamsArray(object arg0, object arg1, object arg2) { }

	public ParamsArray(Object[] args) { }

	public object get_Item(int index) { }

	public int get_Length() { }

	private object GetAtSlow(int index) { }

}

