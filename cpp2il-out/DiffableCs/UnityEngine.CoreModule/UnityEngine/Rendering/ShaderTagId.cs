namespace UnityEngine.Rendering;

public struct ShaderTagId : IEquatable<ShaderTagId>
{
	private int m_Id; //Field offset: 0x0

	public ShaderTagId(string name) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(ShaderTagId other) { }

	public virtual int GetHashCode() { }

}

