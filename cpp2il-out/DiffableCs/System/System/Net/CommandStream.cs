namespace System.Net;

internal class CommandStream : NetworkStreamWrapper
{
	public class PipelineEntry
	{
		internal string Command; //Field offset: 0x10
		internal PipelineEntryFlags Flags; //Field offset: 0x18

		internal PipelineEntry(string command) { }

		internal PipelineEntry(string command, PipelineEntryFlags flags) { }

		internal bool HasFlag(PipelineEntryFlags flags) { }

	}

	[Flags]
	public enum PipelineEntryFlags
	{
		UserCommand = 1,
		GiveDataStream = 2,
		CreateDataConnection = 4,
		DontLogParameter = 8,
	}

	public enum PipelineInstruction
	{
		Abort = 0,
		Advance = 1,
		Pause = 2,
		Reread = 3,
		GiveStream = 4,
	}

	private static readonly AsyncCallback s_writeCallbackDelegate; //Field offset: 0x0
	private static readonly AsyncCallback s_readCallbackDelegate; //Field offset: 0x8
	private bool _recoverableFailure; //Field offset: 0x38
	protected WebRequest _request; //Field offset: 0x40
	protected bool _isAsync; //Field offset: 0x48
	private bool _aborted; //Field offset: 0x49
	protected PipelineEntry[] _commands; //Field offset: 0x50
	protected int _index; //Field offset: 0x58
	private bool _doRead; //Field offset: 0x5C
	private bool _doSend; //Field offset: 0x5D
	private ResponseDescription _currentResponseDescription; //Field offset: 0x60
	protected string _abortReason; //Field offset: 0x68
	private string _buffer; //Field offset: 0x70
	private Encoding _encoding; //Field offset: 0x78
	private Decoder _decoder; //Field offset: 0x80

	protected Encoding Encoding
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	internal bool RecoverableFailure
	{
		internal get { } //Length: 5
	}

	private static CommandStream() { }

	internal CommandStream(TcpClient client) { }

	internal override void Abort(Exception e) { }

	protected override PipelineEntry[] BuildCommandsList(WebRequest request) { }

	internal void CheckContinuePipeline() { }

	protected override bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	protected override void ClearState() { }

	protected Stream ContinueCommandPipeline() { }

	protected virtual void Dispose(bool disposing) { }

	protected Exception GenerateException(string message, WebExceptionStatus status, Exception innerException) { }

	protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException) { }

	protected Encoding get_Encoding() { }

	internal bool get_RecoverableFailure() { }

	protected void InitCommandPipeline(WebRequest request, PipelineEntry[] commands, bool isAsync) { }

	protected void InvokeRequestCallback(object obj) { }

	protected void MarkAsRecoverableFailure() { }

	protected override PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	private bool PostReadCommandProcessing(ref Stream stream) { }

	private bool PostSendCommandProcessing(ref Stream stream) { }

	private static void ReadCallback(IAsyncResult asyncResult) { }

	private ResponseDescription ReceiveCommandResponse() { }

	private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead) { }

	protected void set_Encoding(Encoding value) { }

	internal Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect) { }

	private static void WriteCallback(IAsyncResult asyncResult) { }

}

