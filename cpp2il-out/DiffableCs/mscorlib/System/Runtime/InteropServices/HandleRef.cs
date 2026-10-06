namespace System.Runtime.InteropServices;

[IsReadOnly]
public struct HandleRef
{
	private readonly object _wrapper; //Field offset: 0x0
	private readonly IntPtr _handle; //Field offset: 0x8

	public IntPtr Handle
	{
		 get { } //Length: 5
	}

	public HandleRef(object wrapper, IntPtr handle) { }

	public IntPtr get_Handle() { }

}

