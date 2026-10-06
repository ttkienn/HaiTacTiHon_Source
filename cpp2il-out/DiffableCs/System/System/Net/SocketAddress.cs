namespace System.Net;

[DefaultMember("Item")]
public class SocketAddress
{
	internal int m_Size; //Field offset: 0x10
	internal Byte[] m_Buffer; //Field offset: 0x18
	private bool m_changed; //Field offset: 0x20
	private int m_hash; //Field offset: 0x24

	public AddressFamily Family
	{
		 get { } //Length: 54
	}

	public byte Item
	{
		 get { } //Length: 117
	}

	public int Size
	{
		 get { } //Length: 191
	}

	public SocketAddress(AddressFamily family, int size) { }

	internal SocketAddress(IPAddress ipAddress) { }

	internal SocketAddress(IPAddress ipaddress, int port) { }

	public virtual bool Equals(object comparand) { }

	public AddressFamily get_Family() { }

	public byte get_Item(int offset) { }

	public int get_Size() { }

	public virtual int GetHashCode() { }

	internal IPAddress GetIPAddress() { }

	internal IPEndPoint GetIPEndPoint() { }

	public virtual string ToString() { }

}

