namespace Mono.Btls;

[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
internal sealed class MonoBtlsVerifyCallback : MulticastDelegate
{

	public MonoBtlsVerifyCallback(object object, IntPtr method) { }

	public override int Invoke(MonoBtlsX509StoreCtx ctx) { }

}

