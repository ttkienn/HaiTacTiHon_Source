namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/MeshFilter.h")]
[RequireComponent(typeof(Transform))]
public sealed class MeshFilter : Component
{

	[RequiredByNativeCode]
	private void DontStripMeshFilter() { }

}

