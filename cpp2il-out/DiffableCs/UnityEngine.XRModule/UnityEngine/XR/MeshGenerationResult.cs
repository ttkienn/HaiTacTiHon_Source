namespace UnityEngine.XR;

[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
[RequiredByNativeCode]
public struct MeshGenerationResult : IEquatable<MeshGenerationResult>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly MeshId <MeshId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Mesh <Mesh>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly MeshCollider <MeshCollider>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly MeshGenerationStatus <Status>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly MeshVertexAttributes <Attributes>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly ulong <Timestamp>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Vector3 <Position>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Quaternion <Rotation>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Vector3 <Scale>k__BackingField; //Field offset: 0x4C

	public MeshVertexAttributes Attributes
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
	}

	public Mesh Mesh
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
	}

	public MeshCollider MeshCollider
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
	}

	public MeshId MeshId
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 10
	}

	public Vector3 Position
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 19
	}

	public Quaternion Rotation
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 11
	}

	public Vector3 Scale
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 19
	}

	public MeshGenerationStatus Status
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(MeshGenerationResult other) { }

	[CompilerGenerated]
	[IsReadOnly]
	public MeshVertexAttributes get_Attributes() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Mesh get_Mesh() { }

	[CompilerGenerated]
	[IsReadOnly]
	public MeshCollider get_MeshCollider() { }

	[CompilerGenerated]
	[IsReadOnly]
	public MeshId get_MeshId() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector3 get_Position() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Quaternion get_Rotation() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector3 get_Scale() { }

	[CompilerGenerated]
	[IsReadOnly]
	public MeshGenerationStatus get_Status() { }

	public virtual int GetHashCode() { }

}

