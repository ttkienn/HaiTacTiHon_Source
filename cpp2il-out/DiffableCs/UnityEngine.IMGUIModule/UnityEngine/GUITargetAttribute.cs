namespace UnityEngine;

[AttributeUsage(AttributeTargets::Method (64))]
public class GUITargetAttribute : Attribute
{
	internal int displayMask; //Field offset: 0x10

	[RequiredByNativeCode]
	private static int GetGUITargetAttrValue(Type klass, string methodName) { }

}

