namespace UnityEngine.Purchasing.Telemetry;

internal class TelemetryQueue
{
	internal const int k_maxQueueSize = 10; //Field offset: 0x0
	private ConcurrentQueue<TTelemetryEventParams> m_Queue; //Field offset: 0x0
	private readonly Action<TTelemetryEventParams> m_SendTelemetryEvent; //Field offset: 0x0

	public TelemetryQueue`1(Action<TTelemetryEventParams> sendTelemetryEvent) { }

	internal void QueueEvent(TTelemetryEventParams telemetryEvent) { }

	internal void SendQueuedEvents() { }

}

