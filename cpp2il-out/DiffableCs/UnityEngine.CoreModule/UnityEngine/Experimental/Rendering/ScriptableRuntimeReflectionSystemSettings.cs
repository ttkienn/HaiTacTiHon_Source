namespace UnityEngine.Experimental.Rendering;

[NativeHeader("Runtime/Camera/ScriptableRuntimeReflectionSystem.h")]
[RequiredByNativeCode]
public static class ScriptableRuntimeReflectionSystemSettings
{
	private static ScriptableRuntimeReflectionSystemWrapper s_Instance; //Field offset: 0x0

	private static ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_instance
	{
		[RequiredByNativeCode]
		private get { } //Length: 78
	}

	private static IScriptableRuntimeReflectionSystem Internal_ScriptableRuntimeReflectionSystemSettings_system
	{
		[RequiredByNativeCode]
		private set { } //Length: 277
	}

	private static ScriptableRuntimeReflectionSystemSettings() { }

	[RequiredByNativeCode]
	private static ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::AfterSceneLoad (0))]
	[StaticAccessor("ScriptableRuntimeReflectionSystem", StaticAccessorType::DoubleColon (2))]
	private static void ScriptingDirtyReflectionSystemInstance() { }

	[RequiredByNativeCode]
	private static void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(IScriptableRuntimeReflectionSystem value) { }

}

