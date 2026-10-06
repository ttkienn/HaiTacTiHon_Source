namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshingSubsystem.h")]
[UsedByNativeCode]
public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor>
{
	[IsReadOnly]
	[NativeConditional("ENABLE_XR")]
	private struct MeshTransformList : IDisposable
	{
		private readonly IntPtr m_Self; //Field offset: 0x0

		public override void Dispose() { }

		[FreeFunction("UnityXRMeshTransformList_Dispose")]
		private static void Dispose(IntPtr self) { }

	}


	public XRMeshSubsystem() { }

	[RequiredByNativeCode]
	private void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete) { }

}

