namespace UnityEngine.XR;

[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
[RequiredByNativeCode]
public enum MeshGenerationStatus
{
	Success = 0,
	InvalidMeshId = 1,
	GenerationAlreadyInProgress = 2,
	Canceled = 3,
	UnknownError = 4,
}

