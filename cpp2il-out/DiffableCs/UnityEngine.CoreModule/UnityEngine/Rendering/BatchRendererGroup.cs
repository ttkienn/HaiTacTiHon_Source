namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[NativeHeader("Runtime/Math/Matrix4x4.h")]
[RequiredByNativeCode]
public class BatchRendererGroup
{
	internal sealed class OnPerformCulling : MulticastDelegate
	{

		public OnPerformCulling(object object, IntPtr method) { }

		public override JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, BatchCullingOutput cullingOutput, IntPtr userContext) { }

	}

	private IntPtr m_GroupHandle; //Field offset: 0x10
	private OnPerformCulling m_PerformCulling; //Field offset: 0x18

	[RequiredByNativeCode]
	private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters, IntPtr userContext) { }

}

