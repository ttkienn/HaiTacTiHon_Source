namespace Unity.Collections.LowLevel.Unsafe;

[AttributeUsage(AttributeTargets::Field (256))]
[RequiredByNativeCode]
public sealed class NativeDisableUnsafePtrRestrictionAttribute : Attribute
{

	public NativeDisableUnsafePtrRestrictionAttribute() { }

}

