namespace UnityEngine;

[AttributeUsage(AttributeTargets::Field (256), Inherited = True, AllowMultiple = False)]
[UsedByNativeCode]
public class InspectorNameAttribute : PropertyAttribute
{
	public readonly string displayName; //Field offset: 0x10

}

