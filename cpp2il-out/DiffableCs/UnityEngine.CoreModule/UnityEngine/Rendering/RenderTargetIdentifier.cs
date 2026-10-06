namespace UnityEngine.Rendering;

public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier>
{
	private BuiltinRenderTextureType m_Type; //Field offset: 0x0
	private int m_NameID; //Field offset: 0x4
	private int m_InstanceID; //Field offset: 0x8
	private IntPtr m_BufferPointer; //Field offset: 0x10
	private int m_MipLevel; //Field offset: 0x18
	private CubemapFace m_CubeFace; //Field offset: 0x1C
	private int m_DepthSlice; //Field offset: 0x20

	public override bool Equals(RenderTargetIdentifier rhs) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

