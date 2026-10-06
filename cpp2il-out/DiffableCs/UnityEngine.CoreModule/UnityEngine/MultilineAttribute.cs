namespace UnityEngine;

[AttributeUsage(AttributeTargets::Field (256), Inherited = True, AllowMultiple = False)]
public sealed class MultilineAttribute : PropertyAttribute
{
	public readonly int lines; //Field offset: 0x10

	public MultilineAttribute() { }

}

