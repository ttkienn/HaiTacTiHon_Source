namespace Unity.Services.Analytics.Internal;

internal interface IDiskCache
{

	public void Clear() { }

	public bool Read(List<EventSummary> eventSummaries, Stream buffer) { }

	public void Write(List<EventSummary> eventSummaries, Stream payload) { }

}

