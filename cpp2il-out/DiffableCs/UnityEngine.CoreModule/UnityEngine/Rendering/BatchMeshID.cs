namespace UnityEngine.Rendering;

[NativeClass("BatchMeshID")]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct BatchMeshID : IEquatable<BatchMeshID>
{
	public static readonly BatchMeshID Null; //Field offset: 0x0
	public uint value; //Field offset: 0x0

	private static BatchMeshID() { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(BatchMeshID other) { }

	public virtual int GetHashCode() { }

}

