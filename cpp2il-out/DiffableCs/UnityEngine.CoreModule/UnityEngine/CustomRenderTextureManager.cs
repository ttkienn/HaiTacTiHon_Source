namespace UnityEngine;

[NativeHeader("Runtime/Graphics/CustomRenderTextureManager.h")]
public static class CustomRenderTextureManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<CustomRenderTexture> textureLoaded; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<CustomRenderTexture> textureUnloaded; //Field offset: 0x8

	[RequiredByNativeCode]
	private static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source) { }

	[RequiredByNativeCode]
	private static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source) { }

}

