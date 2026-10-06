namespace UnityEngine;

[ExtensionOfNativeClass]
[NativeClass(null)]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[RequiredByNativeCode]
public class ScriptableObject : object
{

	public ScriptableObject() { }

	public static ScriptableObject CreateInstance(Type type) { }

	public static T CreateInstance() { }

	[NativeMethod(IsThreadSafe = True)]
	private static void CreateScriptableObject(ScriptableObject self) { }

	[NativeMethod(Name = "Scripting::CreateScriptableObjectWithType", IsFreeFunction = True, ThrowsException = True)]
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }

}

