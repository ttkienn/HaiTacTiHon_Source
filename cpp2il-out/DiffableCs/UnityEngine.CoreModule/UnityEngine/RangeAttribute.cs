namespace UnityEngine;

[AttributeUsage(AttributeTargets::Field (256), Inherited = True, AllowMultiple = False)]
public sealed class RangeAttribute : PropertyAttribute
{
	public readonly float min; //Field offset: 0x10
	public readonly float max; //Field offset: 0x14

	public RangeAttribute(float min, float max) { }

}

