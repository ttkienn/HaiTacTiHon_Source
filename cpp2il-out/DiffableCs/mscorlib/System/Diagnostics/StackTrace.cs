namespace System.Diagnostics;

[ComVisible(True)]
[MonoTODO("Serialized objects are not compatible with .NET")]
public class StackTrace
{
	public enum TraceFormat
	{
		Normal = 0,
		TrailingNewLine = 1,
		NoResourceLookup = 2,
	}

	private static bool isAotidSet; //Field offset: 0x0
	private static string aotid; //Field offset: 0x8
	private StackFrame[] frames; //Field offset: 0x10
	private readonly StackTrace[] captured_traces; //Field offset: 0x18
	private bool debug_info; //Field offset: 0x20

	public override int FrameCount
	{
		 get { } //Length: 18
	}

	public StackTrace() { }

	public StackTrace(bool fNeedFileInfo) { }

	public StackTrace(int skipFrames, bool fNeedFileInfo) { }

	public StackTrace(Exception e, bool fNeedFileInfo) { }

	public StackTrace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	private bool AddFrames(StringBuilder sb, bool separator, out bool isAsync) { }

	private static void ConvertAsyncStateMachineMethod(ref MethodBase method, ref Type declaringType) { }

	public override int get_FrameCount() { }

	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	private static string GetAotId() { }

	public override StackFrame GetFrame(int index) { }

	private void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi, bool needsNewLine, out bool skipped, out bool isAsync) { }

	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	public virtual string ToString() { }

	internal string ToString(TraceFormat traceFormat) { }

}

