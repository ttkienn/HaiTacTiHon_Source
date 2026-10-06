namespace Newtonsoft.Json.Serialization;

[NullableContext(1)]
public interface ITraceWriter
{

	public TraceLevel LevelFilter
	{
		 get { } //Length: 0
	}

	public TraceLevel get_LevelFilter() { }

	public void Trace(TraceLevel level, string message, Exception ex) { }

}

