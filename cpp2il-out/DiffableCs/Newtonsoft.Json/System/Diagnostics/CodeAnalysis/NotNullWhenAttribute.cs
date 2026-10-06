namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets::Parameter (2048), AllowMultiple = False)]
internal sealed class NotNullWhenAttribute : Attribute
{
	[CompilerGenerated]
	private readonly bool <ReturnValue>k__BackingField; //Field offset: 0x10

	public bool ReturnValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public NotNullWhenAttribute(bool returnValue) { }

	[CompilerGenerated]
	public bool get_ReturnValue() { }

}

