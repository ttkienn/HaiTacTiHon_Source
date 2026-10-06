namespace UnityEngine.UIElements.UIR;

internal struct BMPAlloc
{
	public static readonly BMPAlloc Invalid; //Field offset: 0x0
	public int page; //Field offset: 0x0
	public ushort pageLine; //Field offset: 0x4
	public byte bitIndex; //Field offset: 0x6
	public OwnedState ownedState; //Field offset: 0x7

	private static BMPAlloc() { }

	public bool Equals(BMPAlloc other) { }

	public bool IsValid() { }

	public virtual string ToString() { }

}

