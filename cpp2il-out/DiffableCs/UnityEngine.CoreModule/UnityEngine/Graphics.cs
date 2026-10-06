namespace UnityEngine;

[NativeHeader("Runtime/Graphics/CopyTexture.h")]
[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/ColorGamut.h")]
public class Graphics
{
	internal static readonly int kMaxDrawMeshInstanceCount; //Field offset: 0x0
	internal static Dictionary<Int32, RenderInstancedDataLayout> s_RenderInstancedDataLayouts; //Field offset: 0x8

	private static Graphics() { }

	public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass) { }

	public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass) { }

	public static void DrawTexture(Rect screenRect, Texture texture, Material mat, int pass) { }

	[ExcludeFromDocs]
	public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder) { }

	[ExcludeFromDocs]
	public static void DrawTexture(Rect screenRect, Texture texture) { }

	private static void DrawTextureImpl(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass) { }

	[FreeFunction("GraphicsScripting::DrawTexture")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule"}])]
	internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args) { }

	[FreeFunction("GraphicsScripting::GetMaxDrawMeshInstanceCount", IsThreadSafe = True)]
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	[FreeFunction("GraphicsScripting::SetNullRT")]
	private static void Internal_SetNullRT() { }

	[NativeMethod(Name = "GraphicsScripting::SetRTSimple", IsFreeFunction = True, ThrowsException = True)]
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	private static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	[ExcludeFromDocs]
	public static void SetRenderTarget(RenderTexture rt) { }

	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

}

