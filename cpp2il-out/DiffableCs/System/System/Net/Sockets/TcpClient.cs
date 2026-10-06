namespace System.Net.Sockets;

public class TcpClient : IDisposable
{
	private Socket m_ClientSocket; //Field offset: 0x10
	private bool m_Active; //Field offset: 0x18
	private NetworkStream m_DataStream; //Field offset: 0x20
	private AddressFamily m_Family; //Field offset: 0x28
	private bool m_CleanedUp; //Field offset: 0x2C

	public Socket Client
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public TcpClient() { }

	public TcpClient(AddressFamily family) { }

	public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state) { }

	public void Close() { }

	public void Connect(string hostname, int port) { }

	public void Connect(IPEndPoint remoteEP) { }

	public Task ConnectAsync(string host, int port) { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	public void EndConnect(IAsyncResult asyncResult) { }

	protected virtual void Finalize() { }

	public Socket get_Client() { }

	public NetworkStream GetStream() { }

	private void initialize() { }

	public void set_Client(Socket value) { }

}

