namespace UnityEngine;

public struct Ray : IFormattable
{
	private Vector3 m_Origin; //Field offset: 0x0
	private Vector3 m_Direction; //Field offset: 0xC

	public Vector3 direction
	{
		 get { } //Length: 19
	}

	public Vector3 origin
	{
		 get { } //Length: 18
	}

	public Ray(Vector3 origin, Vector3 direction) { }

	public Vector3 get_direction() { }

	public Vector3 get_origin() { }

	public Vector3 GetPoint(float distance) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

