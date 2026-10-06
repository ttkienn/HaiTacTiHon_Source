namespace Mono;

internal struct RuntimePropertyHandle
{
	private IntPtr value; //Field offset: 0x0

	public IntPtr Value
	{
		 get { } //Length: 4
	}

	internal RuntimePropertyHandle(IntPtr v) { }

	public virtual bool Equals(object obj) { }

	public IntPtr get_Value() { }

	public virtual int GetHashCode() { }

}

