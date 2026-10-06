namespace System.Runtime.InteropServices;

public interface ICustomMarshaler
{

	public void CleanUpManagedData(object ManagedObj) { }

	public void CleanUpNativeData(IntPtr pNativeData) { }

	public int GetNativeDataSize() { }

	public IntPtr MarshalManagedToNative(object ManagedObj) { }

	public object MarshalNativeToManaged(IntPtr pNativeData) { }

}

