namespace UnityEngine.AI;

[MovedFrom("UnityEngine")]
[NativeHeader("Modules/AI/NavMeshManager.h")]
[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
[StaticAccessor("NavMeshBindings", StaticAccessorType::DoubleColon (2))]
public static class NavMesh
{
	internal sealed class OnNavMeshPreUpdate : MulticastDelegate
	{

		public OnNavMeshPreUpdate(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	public static OnNavMeshPreUpdate onPreUpdate; //Field offset: 0x0

	[RequiredByNativeCode]
	private static void Internal_CallOnNavMeshPreUpdate() { }

}

