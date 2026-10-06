namespace System.Runtime.InteropServices;

[ComVisible(True)]
public struct GCHandle
{
	private IntPtr handle; //Field offset: 0x0

	public bool IsAllocated
	{
		 get { } //Length: 13
	}

	public object Target
	{
		 get { } //Length: 111
		 set { } //Length: 38
	}

	private GCHandle(IntPtr h) { }

	private GCHandle(object obj) { }

	internal GCHandle(object value, GCHandleType type) { }

	public IntPtr AddrOfPinnedObject() { }

	public static GCHandle Alloc(object value) { }

	public static GCHandle Alloc(object value, GCHandleType type) { }

	private static bool CheckCurrentDomain(IntPtr handle) { }

	public virtual bool Equals(object o) { }

	public void Free() { }

	private static void FreeHandle(IntPtr handle) { }

	public static GCHandle FromIntPtr(IntPtr value) { }

	public bool get_IsAllocated() { }

	public object get_Target() { }

	private static IntPtr GetAddrOfPinnedObject(IntPtr handle) { }

	public virtual int GetHashCode() { }

	private static object GetTarget(IntPtr handle) { }

	private static IntPtr GetTargetHandle(object obj, IntPtr handle, GCHandleType type) { }

	public static bool op_Equality(GCHandle a, GCHandle b) { }

	public static IntPtr op_Explicit(GCHandle value) { }

	public static GCHandle op_Explicit(IntPtr value) { }

	public void set_Target(object value) { }

	public static IntPtr ToIntPtr(GCHandle value) { }

}

