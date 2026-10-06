namespace System.Diagnostics.Tracing;

[AttributeUsage(AttributeTargets::Method (64))]
public sealed class NonEventAttribute : Attribute
{

	public NonEventAttribute() { }

}

