namespace System;

internal class MonoAsyncCall
{
	private object msg; //Field offset: 0x10
	private IntPtr cb_method; //Field offset: 0x18
	private object cb_target; //Field offset: 0x20
	private object state; //Field offset: 0x28
	private object res; //Field offset: 0x30
	private object out_args; //Field offset: 0x38

	public MonoAsyncCall() { }

}

