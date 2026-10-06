namespace Unity.Services.Core.Telemetry.Internal;

public interface IMetrics
{

	public void SendGaugeMetric(string name, double value = 0, IDictionary<String, String> tags = null) { }

	public void SendHistogramMetric(string name, double time, IDictionary<String, String> tags = null) { }

	public void SendSumMetric(string name, double value = 1, IDictionary<String, String> tags = null) { }

}

