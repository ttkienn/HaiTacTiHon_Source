namespace System.Net;

public abstract class EndPoint
{

	public override AddressFamily AddressFamily
	{
		 get { } //Length: 39
	}

	protected EndPoint() { }

	public override EndPoint Create(SocketAddress socketAddress) { }

	public override AddressFamily get_AddressFamily() { }

	public override SocketAddress Serialize() { }

}

