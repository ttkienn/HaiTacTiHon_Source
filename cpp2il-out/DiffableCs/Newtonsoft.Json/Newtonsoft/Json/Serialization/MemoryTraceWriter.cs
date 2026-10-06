namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public class MemoryTraceWriter : ITraceWriter
{
	private readonly Queue<String> _traceMessages; //Field offset: 0x10
	private readonly object _lock; //Field offset: 0x18
	[CompilerGenerated]
	private TraceLevel <LevelFilter>k__BackingField; //Field offset: 0x20

	public override TraceLevel LevelFilter
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public MemoryTraceWriter() { }

	[CompilerGenerated]
	public override TraceLevel get_LevelFilter() { }

	public IEnumerable<String> GetTraceMessages() { }

	[CompilerGenerated]
	public void set_LevelFilter(TraceLevel value) { }

	public virtual string ToString() { }

	public override void Trace(TraceLevel level, string message, Exception ex) { }

}

