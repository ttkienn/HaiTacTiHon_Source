namespace System.Runtime.InteropServices;

public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid
{
	private static readonly UIntPtr Uninitialized; //Field offset: 0x0
	private UIntPtr _numBytes; //Field offset: 0x20

	private static SafeBuffer() { }

	[CLSCompliant(False)]
	public void AcquirePointer(ref Byte* pointer) { }

	private static InvalidOperationException NotInitialized() { }

	public void ReleasePointer() { }

}

