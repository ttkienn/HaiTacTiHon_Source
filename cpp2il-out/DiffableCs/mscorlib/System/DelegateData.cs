namespace System;

internal sealed class DelegateData
{
	public Type target_type; //Field offset: 0x10
	public string method_name; //Field offset: 0x18
	public bool curried_first_arg; //Field offset: 0x20

	public DelegateData() { }

}

