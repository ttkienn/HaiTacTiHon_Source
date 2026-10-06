namespace Mono.Btls;

internal class MonoBtlsBioMono : MonoBtlsBio
{
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class BioControlFunc : MulticastDelegate
	{

		public BioControlFunc(object object, IntPtr method) { }

		public override long Invoke(IntPtr bio, ControlCommand command, long arg) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class BioReadFunc : MulticastDelegate
	{

		public BioReadFunc(object object, IntPtr method) { }

		public override int Invoke(IntPtr bio, IntPtr data, int dataLength, out int wantMore) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class BioWriteFunc : MulticastDelegate
	{

		public BioWriteFunc(object object, IntPtr method) { }

		public override int Invoke(IntPtr bio, IntPtr data, int dataLength) { }

	}

	private enum ControlCommand
	{
		Flush = 1,
	}

	private GCHandle handle; //Field offset: 0x20
	private IntPtr instance; //Field offset: 0x28
	private BioReadFunc readFunc; //Field offset: 0x30
	private BioWriteFunc writeFunc; //Field offset: 0x38
	private BioControlFunc controlFunc; //Field offset: 0x40
	private IntPtr readFuncPtr; //Field offset: 0x48
	private IntPtr writeFuncPtr; //Field offset: 0x50
	private IntPtr controlFuncPtr; //Field offset: 0x58
	private IMonoBtlsBioMono backend; //Field offset: 0x60

	public MonoBtlsBioMono(IMonoBtlsBioMono backend) { }

	protected virtual void Close() { }

	private long Control(ControlCommand command, long arg) { }

	[MonoPInvokeCallback(typeof(BioControlFunc))]
	private static long Control(IntPtr instance, ControlCommand command, long arg) { }

	private static void mono_btls_bio_mono_initialize(IntPtr handle, IntPtr instance, IntPtr readFunc, IntPtr writeFunc, IntPtr controlFunc) { }

	private static IntPtr mono_btls_bio_mono_new() { }

	private int OnRead(IntPtr data, int dataLength, out int wantMore) { }

	[MonoPInvokeCallback(typeof(BioReadFunc))]
	private static int OnRead(IntPtr instance, IntPtr data, int dataLength, out int wantMore) { }

	private int OnWrite(IntPtr data, int dataLength) { }

	[MonoPInvokeCallback(typeof(BioWriteFunc))]
	private static int OnWrite(IntPtr instance, IntPtr data, int dataLength) { }

}

