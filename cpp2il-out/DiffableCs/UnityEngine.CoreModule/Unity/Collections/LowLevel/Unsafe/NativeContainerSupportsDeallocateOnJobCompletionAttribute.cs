namespace Unity.Collections.LowLevel.Unsafe;

[AttributeUsage(AttributeTargets::Struct (8))]
[RequiredByNativeCode]
public sealed class NativeContainerSupportsDeallocateOnJobCompletionAttribute : Attribute
{

	public NativeContainerSupportsDeallocateOnJobCompletionAttribute() { }

}

