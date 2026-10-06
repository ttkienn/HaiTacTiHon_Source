namespace System.Collections.Concurrent;

[EventSource(Name = "System.Collections.Concurrent.ConcurrentCollectionsEventSource", Guid = "35167F8E-49B2-4b96-AB86-435B59336B5E")]
internal sealed class CDSCollectionETWBCLProvider : EventSource
{
	public static CDSCollectionETWBCLProvider Log; //Field offset: 0x0

	private static CDSCollectionETWBCLProvider() { }

	private CDSCollectionETWBCLProvider() { }

	[Event(3, Level = EventLevel::Warning (3))]
	public void ConcurrentDictionary_AcquiringAllLocks(int numOfBuckets) { }

}

