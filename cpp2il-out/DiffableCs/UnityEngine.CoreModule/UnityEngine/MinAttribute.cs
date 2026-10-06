namespace UnityEngine;

[AttributeUsage(AttributeTargets::Field (256), Inherited = True, AllowMultiple = False)]
public sealed class MinAttribute : PropertyAttribute
{
	public readonly float min; //Field offset: 0x10

	public MinAttribute(float min) { }

}

