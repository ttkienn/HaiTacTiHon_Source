namespace Mono.Interop;

[AttributeUsage(AttributeTargets::Method (64))]
internal sealed class MonoPInvokeCallbackAttribute : Attribute
{

	public MonoPInvokeCallbackAttribute(Type t) { }

}

