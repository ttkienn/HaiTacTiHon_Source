namespace Mono;

internal struct RuntimeEventHandle
{
	private IntPtr value; //Field offset: 0x0

	public IntPtr Value
	{
		 get { } //Length: 4
	}

	internal RuntimeEventHandle(IntPtr v) { }

	public virtual bool Equals(object obj) { }

	public IntPtr get_Value() { }

	public virtual int GetHashCode() { }

}

