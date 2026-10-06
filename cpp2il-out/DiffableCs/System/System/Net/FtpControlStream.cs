namespace System.Net;

internal class FtpControlStream : CommandStream
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public FtpControlStream <>4__this; //Field offset: 0x10
		public TlsStream tlsStream; //Field offset: 0x18

		public <>c__DisplayClass31_0() { }

		internal void <PipelineCallback>b__0(IAsyncResult ar) { }

	}

	private enum GetPathOption
	{
		Normal = 0,
		AssumeFilename = 1,
		AssumeNoFilename = 2,
	}

	private static readonly AsyncCallback s_acceptCallbackDelegate; //Field offset: 0x0
	private static readonly AsyncCallback s_connectCallbackDelegate; //Field offset: 0x8
	private static readonly AsyncCallback s_SSLHandshakeCallback; //Field offset: 0x10
	private Socket _dataSocket; //Field offset: 0x88
	private IPEndPoint _passiveEndPoint; //Field offset: 0x90
	private TlsStream _tlsStream; //Field offset: 0x98
	private StringBuilder _bannerMessage; //Field offset: 0xA0
	private StringBuilder _welcomeMessage; //Field offset: 0xA8
	private StringBuilder _exitMessage; //Field offset: 0xB0
	private WeakReference _credentials; //Field offset: 0xB8
	private string _currentTypeSetting; //Field offset: 0xC0
	private long _contentLength; //Field offset: 0xC8
	private DateTime _lastModified; //Field offset: 0xD0
	private bool _dataHandshakeStarted; //Field offset: 0xD8
	private string _loginDirectory; //Field offset: 0xE0
	private string _establishedServerDirectory; //Field offset: 0xE8
	private string _requestedServerDirectory; //Field offset: 0xF0
	private Uri _responseUri; //Field offset: 0xF8
	private FtpLoginState _loginState; //Field offset: 0x100
	internal FtpStatusCode StatusCode; //Field offset: 0x104
	internal string StatusLine; //Field offset: 0x108

	internal string BannerMessage
	{
		internal get { } //Length: 40
	}

	internal long ContentLength
	{
		internal get { } //Length: 8
	}

	internal NetworkCredential Credentials
	{
		internal get { } //Length: 184
		internal set { } //Length: 165
	}

	internal string ExitMessage
	{
		internal get { } //Length: 40
	}

	internal DateTime LastModified
	{
		internal get { } //Length: 8
	}

	internal Uri ResponseUri
	{
		internal get { } //Length: 8
	}

	internal string WelcomeMessage
	{
		internal get { } //Length: 40
	}

	private static FtpControlStream() { }

	internal FtpControlStream(TcpClient client) { }

	internal void AbortConnect() { }

	private static void AcceptCallback(IAsyncResult asyncResult) { }

	protected virtual PipelineEntry[] BuildCommandsList(WebRequest req) { }

	protected virtual bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	protected virtual void ClearState() { }

	private static void ConnectCallback(IAsyncResult asyncResult) { }

	protected Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket) { }

	private void CreateFtpListenerSocket(FtpWebRequest request) { }

	private string FormatAddress(IPAddress address, int Port) { }

	private string FormatAddressV6(IPAddress address, int port) { }

	private string FormatFtpCommand(string command, string parameter) { }

	internal string get_BannerMessage() { }

	internal long get_ContentLength() { }

	internal NetworkCredential get_Credentials() { }

	internal string get_ExitMessage() { }

	internal DateTime get_LastModified() { }

	internal Uri get_ResponseUri() { }

	internal string get_WelcomeMessage() { }

	private long GetContentLengthFrom213Response(string responseString) { }

	private DateTime GetLastModifiedFrom213Response(string str) { }

	private string GetLoginDirectory(string str) { }

	private static void GetPathInfo(GetPathOption pathOption, Uri uri, out string path, out string directory, out string filename) { }

	private string GetPortCommandLine(FtpWebRequest request) { }

	private int GetPortV4(string responseString) { }

	private int GetPortV6(string responseString) { }

	private TriState IsFtpDataStreamWriteable() { }

	protected virtual PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	private PipelineInstruction QueueOrCreateDataConection(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream, out bool isSocketReady) { }

	private PipelineInstruction QueueOrCreateFtpDataStream(ref Stream stream) { }

	internal void set_Credentials(NetworkCredential value) { }

	private static void SSLHandshakeCallback(IAsyncResult asyncResult) { }

	private void TryUpdateContentLength(string str) { }

	private void TryUpdateResponseUri(string str, FtpWebRequest request) { }

}

