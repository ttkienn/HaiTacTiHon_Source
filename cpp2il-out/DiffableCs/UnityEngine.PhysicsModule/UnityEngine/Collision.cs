namespace UnityEngine;

public class Collision
{
	private ContactPairHeader m_Header; //Field offset: 0x10
	private ContactPair m_Pair; //Field offset: 0x38
	private bool m_Flipped; //Field offset: 0x60
	private ContactPoint[] m_LegacyContacts; //Field offset: 0x68

	internal bool Flipped
	{
		internal set { } //Length: 4
	}

	public Collision() { }

	internal Collision(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	internal void Reuse(in ContactPairHeader header, in ContactPair pair) { }

	internal void set_Flipped(bool value) { }

}

