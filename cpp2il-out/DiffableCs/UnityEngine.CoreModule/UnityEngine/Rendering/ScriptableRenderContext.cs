namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderContext.bindings.h")]
[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableDrawRenderersUtility.h")]
[NativeHeader("Modules/UI/CanvasManager.h")]
[NativeHeader("Modules/UI/Canvas.h")]
[NativeType("Runtime/Graphics/ScriptableRenderLoop/ScriptableRenderContext.h")]
public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext>
{
	private static readonly ShaderTagId kRenderTypeTag; //Field offset: 0x0
	private IntPtr m_Ptr; //Field offset: 0x0

	private static ScriptableRenderContext() { }

	internal ScriptableRenderContext(IntPtr ptr) { }

	public override bool Equals(ScriptableRenderContext other) { }

	public virtual bool Equals(object obj) { }

	internal void GetCameras(List<Camera> results) { }

	private void GetCameras_Internal(Type listType, object resultList) { }

	private static void GetCameras_Internal_Injected(ref ScriptableRenderContext _unity_self, Type listType, object resultList) { }

	public virtual int GetHashCode() { }

}

