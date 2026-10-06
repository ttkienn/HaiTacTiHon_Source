namespace System;

[AttributeUsage(AttributeTargets::Field (256), Inherited = False)]
public sealed class NonSerializedAttribute : Attribute
{

	public NonSerializedAttribute() { }

}

