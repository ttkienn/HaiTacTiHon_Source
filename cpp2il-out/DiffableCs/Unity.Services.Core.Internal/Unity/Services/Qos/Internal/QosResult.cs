namespace Unity.Services.Qos.Internal;

public struct QosResult
{
	public string Region; //Field offset: 0x0
	public int AverageLatencyMs; //Field offset: 0x8
	public float PacketLossPercent; //Field offset: 0xC

}

