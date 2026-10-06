namespace UnityEngine;

[UsedByNativeCode]
public struct BoundsInt : IEquatable<BoundsInt>, IFormattable
{
	private Vector3Int m_Position; //Field offset: 0x0
	private Vector3Int m_Size; //Field offset: 0xC

	public Vector3Int position
	{
		 get { } //Length: 18
		 set { } //Length: 15
	}

	public Vector3Int size
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public BoundsInt(Vector3Int position, Vector3Int size) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(BoundsInt other) { }

	public Vector3Int get_position() { }

	public Vector3Int get_size() { }

	public virtual int GetHashCode() { }

	public void set_position(Vector3Int value) { }

	public void set_size(Vector3Int value) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

