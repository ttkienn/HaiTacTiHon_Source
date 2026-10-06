namespace System.Net.Sockets;

internal sealed class SocketAsyncResult : IOAsyncResult
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static WaitCallback <>9__27_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Complete>b__27_0(object state) { }

	}

	public Socket socket; //Field offset: 0x30
	public SocketOperation operation; //Field offset: 0x38
	private Exception DelayedException; //Field offset: 0x40
	public EndPoint EndPoint; //Field offset: 0x48
	public Memory<Byte> Buffer; //Field offset: 0x50
	public int Offset; //Field offset: 0x60
	public int Size; //Field offset: 0x64
	public SocketFlags SockFlags; //Field offset: 0x68
	public Socket AcceptSocket; //Field offset: 0x70
	public IPAddress[] Addresses; //Field offset: 0x78
	public int Port; //Field offset: 0x80
	public IList<ArraySegment`1<Byte>> Buffers; //Field offset: 0x88
	public bool ReuseSocket; //Field offset: 0x90
	public int CurrentAddress; //Field offset: 0x94
	public Socket AcceptedSocket; //Field offset: 0x98
	public int Total; //Field offset: 0xA0
	internal int error; //Field offset: 0xA4
	public int EndCalled; //Field offset: 0xA8

	public SocketError ErrorCode
	{
		 get { } //Length: 150
	}

	public IntPtr Handle
	{
		 get { } //Length: 45
	}

	public SocketAsyncResult() { }

	public SocketAsyncResult(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	public void CheckIfThrowDelayedException() { }

	public void Complete() { }

	public void Complete(bool synch) { }

	public void Complete(int total) { }

	public void Complete(Exception e, bool synch) { }

	public void Complete(Exception e) { }

	public void Complete(Socket s) { }

	public void Complete(Socket s, int total) { }

	internal virtual void CompleteDisposed() { }

	public SocketError get_ErrorCode() { }

	public IntPtr get_Handle() { }

	public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

}

