namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False, AllowMultiple = False)]
public sealed class RuntimeCompatibilityAttribute : Attribute
{
	[CompilerGenerated]
	private bool <WrapNonExceptionThrows>k__BackingField; //Field offset: 0x10

	public bool WrapNonExceptionThrows
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public RuntimeCompatibilityAttribute() { }

	[CompilerGenerated]
	public void set_WrapNonExceptionThrows(bool value) { }

}

