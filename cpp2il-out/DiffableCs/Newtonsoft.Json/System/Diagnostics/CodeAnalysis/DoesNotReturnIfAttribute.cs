namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets::Parameter (2048), Inherited = False)]
internal class DoesNotReturnIfAttribute : Attribute
{
	[CompilerGenerated]
	private readonly bool <ParameterValue>k__BackingField; //Field offset: 0x10

	public bool ParameterValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public DoesNotReturnIfAttribute(bool parameterValue) { }

	[CompilerGenerated]
	public bool get_ParameterValue() { }

}

