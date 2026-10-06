namespace UnityEngine.SceneManagement;

[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
[RequiredByNativeCode]
public class SceneManager
{
	internal static bool s_AllowLoadScene; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static UnityAction<Scene, LoadSceneMode> sceneLoaded; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static UnityAction<Scene> sceneUnloaded; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static UnityAction<Scene, Scene> activeSceneChanged; //Field offset: 0x18

	private static SceneManager() { }

	[RequiredByNativeCode]
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	[RequiredByNativeCode]
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[RequiredByNativeCode]
	private static void Internal_SceneUnloaded(Scene scene) { }

	[RequiredByNativeCode]
	internal static AsyncOperation LoadFirstScene_Internal(bool async) { }

}

