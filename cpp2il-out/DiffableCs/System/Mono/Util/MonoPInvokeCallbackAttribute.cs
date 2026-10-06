namespace Mono.Util;

[AttributeUsage(AttributeTargets::Method (64))]
[Conditional("FULL_AOT_RUNTIME")]
[Conditional("UNITY")]
[Conditional("MONOTOUCH")]
internal sealed class MonoPInvokeCallbackAttribute : Attribute
{

	public MonoPInvokeCallbackAttribute(Type t) { }

}

