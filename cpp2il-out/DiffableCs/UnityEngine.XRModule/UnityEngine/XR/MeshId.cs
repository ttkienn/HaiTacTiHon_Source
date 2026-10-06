namespace UnityEngine.XR;

[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
[UsedByNativeCode]
public struct MeshId : IEquatable<MeshId>
{
	private static MeshId s_InvalidId; //Field offset: 0x0
	private ulong m_SubId1; //Field offset: 0x0
	private ulong m_SubId2; //Field offset: 0x8

	private static MeshId() { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(MeshId other) { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

