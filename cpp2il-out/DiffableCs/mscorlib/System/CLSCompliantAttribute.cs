namespace System;

[AttributeUsage(AttributeTargets::All (32767), Inherited = True, AllowMultiple = False)]
public sealed class CLSCompliantAttribute : Attribute
{
	private bool _compliant; //Field offset: 0x10

	public CLSCompliantAttribute(bool isCompliant) { }

}

