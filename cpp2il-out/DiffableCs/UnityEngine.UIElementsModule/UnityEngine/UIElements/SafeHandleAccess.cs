namespace UnityEngine.UIElements;

internal struct SafeHandleAccess
{
	private IntPtr m_Handle; //Field offset: 0x0

	public SafeHandleAccess(IntPtr ptr) { }

	public bool IsNull() { }

	public static IntPtr op_Implicit(SafeHandleAccess a) { }

}

