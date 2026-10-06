namespace UnityEngine;

[NativeClass("RaycastHit2D", "struct RaycastHit2D;")]
[NativeHeader("Runtime/Interfaces/IPhysics2D.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct RaycastHit2D
{
	[NativeName("centroid")]
	private Vector2 m_Centroid; //Field offset: 0x0
	[NativeName("point")]
	private Vector2 m_Point; //Field offset: 0x8
	[NativeName("normal")]
	private Vector2 m_Normal; //Field offset: 0x10
	[NativeName("distance")]
	private float m_Distance; //Field offset: 0x18
	[NativeName("fraction")]
	private float m_Fraction; //Field offset: 0x1C
	[NativeName("collider")]
	private int m_Collider; //Field offset: 0x20

	public Collider2D collider
	{
		 get { } //Length: 171
	}

	public float distance
	{
		 get { } //Length: 8
	}

	public Vector2 normal
	{
		 get { } //Length: 105
	}

	public Vector2 point
	{
		 get { } //Length: 19
	}

	public Collider2D get_collider() { }

	public float get_distance() { }

	public Vector2 get_normal() { }

	public Vector2 get_point() { }

}

