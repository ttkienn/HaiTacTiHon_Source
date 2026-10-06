namespace UnityEngine.Rendering;

[NativeClass("BatchID")]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct BatchID : IEquatable<BatchID>
{
	public static readonly BatchID Null; //Field offset: 0x0
	public uint value; //Field offset: 0x0

	private static BatchID() { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(BatchID other) { }

	public virtual int GetHashCode() { }

}

