namespace System.Net;

internal class ReceiveState
{
	internal ResponseDescription Resp; //Field offset: 0x10
	internal int ValidThrough; //Field offset: 0x18
	internal Byte[] Buffer; //Field offset: 0x20
	internal CommandStream Connection; //Field offset: 0x28

	internal ReceiveState(CommandStream connection) { }

}

