namespace System.Net;

public class IPEndPoint : EndPoint
{
	internal static IPEndPoint Any; //Field offset: 0x0
	internal static IPEndPoint IPv6Any; //Field offset: 0x8
	private IPAddress _address; //Field offset: 0x10
	private int _port; //Field offset: 0x18

	public IPAddress Address
	{
		 get { } //Length: 5
	}

	public virtual AddressFamily AddressFamily
	{
		 get { } //Length: 29
	}

	public int Port
	{
		 get { } //Length: 4
	}

	private static IPEndPoint() { }

	public IPEndPoint(IPAddress address, int port) { }

	public virtual EndPoint Create(SocketAddress socketAddress) { }

	public virtual bool Equals(object comparand) { }

	public IPAddress get_Address() { }

	public virtual AddressFamily get_AddressFamily() { }

	public int get_Port() { }

	public virtual int GetHashCode() { }

	public virtual SocketAddress Serialize() { }

	public virtual string ToString() { }

}

