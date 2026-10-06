namespace UnityEngine;

[AttributeUsage(AttributeTargets::All (32767), Inherited = True, AllowMultiple = False)]
public class TooltipAttribute : PropertyAttribute
{
	public readonly string tooltip; //Field offset: 0x10

	public TooltipAttribute(string tooltip) { }

}

