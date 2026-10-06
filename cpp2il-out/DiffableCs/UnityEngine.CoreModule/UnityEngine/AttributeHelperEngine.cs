namespace UnityEngine;

internal class AttributeHelperEngine
{
	public static DisallowMultipleComponent[] _disallowMultipleComponentArray; //Field offset: 0x0
	public static ExecuteInEditMode[] _executeInEditModeArray; //Field offset: 0x8
	public static RequireComponent[] _requireComponentArray; //Field offset: 0x10

	private static AttributeHelperEngine() { }

	[RequiredByNativeCode]
	private static int CheckIsEditorScript(Type klass) { }

	private static T GetCustomAttributeOfType(Type klass) { }

	[RequiredByNativeCode]
	private static int GetDefaultExecutionOrderFor(Type klass) { }

	private static int GetExecuteMode(Type klass) { }

	[RequiredByNativeCode]
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	[RequiredByNativeCode]
	private static Type[] GetRequiredComponents(Type klass) { }

}

