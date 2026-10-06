namespace UnityEngine.Rendering;

[NativeClass("BatchMaterialID")]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct BatchMaterialID : IEquatable<BatchMaterialID>
{
	public static readonly BatchMaterialID Null; //Field offset: 0x0
	public uint value; //Field offset: 0x0

	private static BatchMaterialID() { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(BatchMaterialID other) { }

	public virtual int GetHashCode() { }

}

