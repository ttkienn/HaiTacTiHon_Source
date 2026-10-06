namespace UnityEngine.Rendering;

public struct LODParameters : IEquatable<LODParameters>
{
	private int m_IsOrthographic; //Field offset: 0x0
	private Vector3 m_CameraPosition; //Field offset: 0x4
	private float m_FieldOfView; //Field offset: 0x10
	private float m_OrthoSize; //Field offset: 0x14
	private int m_CameraPixelHeight; //Field offset: 0x18

	public override bool Equals(LODParameters other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

