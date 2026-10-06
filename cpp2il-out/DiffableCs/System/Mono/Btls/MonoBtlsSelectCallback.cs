namespace Mono.Btls;

[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
internal sealed class MonoBtlsSelectCallback : MulticastDelegate
{

	public MonoBtlsSelectCallback(object object, IntPtr method) { }

	public override int Invoke(String[] acceptableIssuers) { }

}

