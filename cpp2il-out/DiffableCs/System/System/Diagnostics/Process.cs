namespace System.Diagnostics;

[DefaultEvent("Exited")]
[DefaultProperty("StartInfo")]
[MonitoringDescription("Provides access to local and remote processes, enabling starting and stopping of local processes.")]
public class Process : Component
{
	private enum State
	{
		HaveId = 1,
		IsLocal = 2,
		IsNt = 4,
		HaveProcessInfo = 8,
		Exited = 16,
		Associated = 32,
		IsWin2k = 64,
		HaveNtProcessInfo = 12,
	}

	private enum StreamReadMode
	{
		undefined = 0,
		syncMode = 1,
		asyncMode = 2,
	}

	private bool haveProcessId; //Field offset: 0x28
	private int processId; //Field offset: 0x2C
	private bool haveProcessHandle; //Field offset: 0x30
	private SafeProcessHandle m_processHandle; //Field offset: 0x38
	private bool isRemoteMachine; //Field offset: 0x40
	private string machineName; //Field offset: 0x48
	private int m_processAccess; //Field offset: 0x50
	private ProcessThreadCollection threads; //Field offset: 0x58
	private ProcessModuleCollection modules; //Field offset: 0x60
	private bool haveWorkingSetLimits; //Field offset: 0x68
	private bool havePriorityClass; //Field offset: 0x69
	private bool watchForExit; //Field offset: 0x6A
	private bool watchingForExit; //Field offset: 0x6B
	private EventHandler onExited; //Field offset: 0x70
	private bool exited; //Field offset: 0x78
	private int exitCode; //Field offset: 0x7C
	private bool signaled; //Field offset: 0x80
	private bool haveExitTime; //Field offset: 0x81
	private bool raisedOnExited; //Field offset: 0x82
	private RegisteredWaitHandle registeredWaitHandle; //Field offset: 0x88
	private WaitHandle waitHandle; //Field offset: 0x90
	private ISynchronizeInvoke synchronizingObject; //Field offset: 0x98
	private StreamReader standardOutput; //Field offset: 0xA0
	private StreamWriter standardInput; //Field offset: 0xA8
	private StreamReader standardError; //Field offset: 0xB0
	private bool disposed; //Field offset: 0xB8
	private StreamReadMode outputStreamReadMode; //Field offset: 0xBC
	private StreamReadMode errorStreamReadMode; //Field offset: 0xC0
	private StreamReadMode inputStreamReadMode; //Field offset: 0xC4
	internal AsyncStreamReader output; //Field offset: 0xC8
	internal AsyncStreamReader error; //Field offset: 0xD0
	private string process_name; //Field offset: 0xD8

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[MonitoringDescription("Indicates if the process component is associated with a real process.")]
	private bool Associated
	{
		private get { } //Length: 13
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[MonitoringDescription("Indicates if the associated process has been terminated.")]
	public bool HasExited
	{
		 get { } //Length: 824
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[MonitoringDescription("The unique identifier for the process.")]
	public int Id
	{
		 get { } //Length: 31
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[MonitoringDescription("The name of this process.")]
	public string ProcessName
	{
		 get { } //Length: 590
	}

	[Browsable(False)]
	[DefaultValue(null)]
	[MonitoringDescription("The object used to marshal the event handler calls issued as a result of a Process exit.")]
	public ISynchronizeInvoke SynchronizingObject
	{
		 get { } //Length: 386
	}

	private Process(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo) { }

	public void Close() { }

	protected virtual void Dispose(bool disposing) { }

	private void EnsureState(State state) { }

	private bool get_Associated() { }

	public bool get_HasExited() { }

	public int get_Id() { }

	public string get_ProcessName() { }

	public ISynchronizeInvoke get_SynchronizingObject() { }

	public static Process GetCurrentProcess() { }

	private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited) { }

	private SafeProcessHandle GetProcessHandle(int access) { }

	protected void OnExited() { }

	private static string ProcessName_icall(IntPtr handle) { }

	private static string ProcessName_internal(SafeProcessHandle handle) { }

	private void RaiseOnExited() { }

	public void Refresh() { }

	private void ReleaseProcessHandle(SafeProcessHandle handle) { }

	private void StopWatchingForExit() { }

	public virtual string ToString() { }

}

