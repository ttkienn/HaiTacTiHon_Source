namespace Unity.Services.Analytics.Internal;

internal interface IBufferSystemCalls
{

	public string GenerateGuid() { }

	public TimeSpan GetTimeZoneUtcOffset(DateTime dateTime) { }

	public DateTime Now() { }

}

