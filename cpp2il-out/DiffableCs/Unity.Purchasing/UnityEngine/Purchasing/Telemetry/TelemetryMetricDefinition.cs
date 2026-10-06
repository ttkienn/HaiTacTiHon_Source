namespace UnityEngine.Purchasing.Telemetry;

internal struct TelemetryMetricDefinition
{
	[CompilerGenerated]
	private readonly TelemetryMetricTypes <MetricType>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <MetricName>k__BackingField; //Field offset: 0x8

	public string MetricName
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
	}

	public TelemetryMetricTypes MetricType
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 3
	}

	public TelemetryMetricDefinition(string metricName, TelemetryMetricTypes metricType = 2) { }

	[CompilerGenerated]
	[IsReadOnly]
	public string get_MetricName() { }

	[CompilerGenerated]
	[IsReadOnly]
	public TelemetryMetricTypes get_MetricType() { }

	public static TelemetryMetricDefinition op_Implicit(string name) { }

}

