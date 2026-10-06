namespace System;

[ComVisible(True)]
public class Exception : ISerializable
{
	public enum ExceptionMessageKind
	{
		ThreadAbort = 1,
		ThreadInterrupted = 2,
		OutOfMemory = 3,
	}

	[OptionalField]
	private static object s_EDILock; //Field offset: 0x0
	private const int _COMPlusExceptionCode = -532462766; //Field offset: 0x0
	private string _className; //Field offset: 0x10
	internal string _message; //Field offset: 0x18
	private IDictionary _data; //Field offset: 0x20
	private Exception _innerException; //Field offset: 0x28
	private string _helpURL; //Field offset: 0x30
	private object _stackTrace; //Field offset: 0x38
	private string _stackTraceString; //Field offset: 0x40
	private string _remoteStackTraceString; //Field offset: 0x48
	private int _remoteStackIndex; //Field offset: 0x50
	private object _dynamicMethods; //Field offset: 0x58
	internal int _HResult; //Field offset: 0x60
	private string _source; //Field offset: 0x68
	[OptionalField(VersionAdded = 4)]
	private SafeSerializationManager _safeSerializationManager; //Field offset: 0x70
	internal StackTrace[] captured_traces; //Field offset: 0x78
	private IntPtr[] native_trace_ips; //Field offset: 0x80
	private int caught_in_unmanaged; //Field offset: 0x88

	public override IDictionary Data
	{
		 get { } //Length: 105
	}

	public int HResult
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public override Exception InnerException
	{
		 get { } //Length: 5
	}

	public override string Message
	{
		 get { } //Length: 284
	}

	public override string Source
	{
		 get { } //Length: 326
	}

	public override string StackTrace
	{
		 get { } //Length: 63
	}

	private static Exception() { }

	public Exception() { }

	public Exception(string message) { }

	public Exception(string message, Exception innerException) { }

	protected Exception(SerializationInfo info, StreamingContext context) { }

	internal Exception FixRemotingException() { }

	public override IDictionary get_Data() { }

	public int get_HResult() { }

	public override Exception get_InnerException() { }

	public override string get_Message() { }

	public override string get_Source() { }

	public override string get_StackTrace() { }

	private string GetClassName() { }

	internal static string GetMessageFromNativeResources(ExceptionMessageKind kind) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private string GetStackTrace(bool needFileInfo) { }

	public override Type GetType() { }

	private void Init() { }

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context) { }

	internal static void ReportUnhandledException(Exception exception) { }

	internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo) { }

	protected void set_HResult(int value) { }

	internal void SetErrorCode(int hr) { }

	private string StripFileInfo(string stackTrace, bool isRemoteStackTrace) { }

	public virtual string ToString() { }

	private string ToString(bool needFileLineInfo, bool needMessage) { }

}

