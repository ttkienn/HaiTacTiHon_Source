namespace Unity.Services.Analytics.Internal;

internal class DiskCache : IDiskCache
{
	internal const string k_FileHeaderString = "UGSEventCache"; //Field offset: 0x0
	internal const int k_CacheFileVersionOne = 1; //Field offset: 0x0
	internal const int k_CacheFileVersionTwo = 2; //Field offset: 0x0
	private readonly string k_CacheFilePath; //Field offset: 0x10
	private readonly IFileSystemCalls k_SystemCalls; //Field offset: 0x18
	private readonly long k_CacheFileMaximumSize; //Field offset: 0x20

	internal DiskCache(IFileSystemCalls systemCalls) { }

	internal DiskCache(string cacheFilePath, IFileSystemCalls systemCalls, long maximumFileSize) { }

	public override void Clear() { }

	public override bool Read(List<EventSummary> eventSummaries, Stream buffer) { }

	private void ReadVersionOneCacheFile(in List<EventSummary>& eventEndIndices, BinaryReader reader, in Stream buffer) { }

	private void ReadVersionTwoCacheFile(in List<EventSummary>& eventSummaries, BinaryReader reader, in Stream buffer) { }

	public override void Write(List<EventSummary> eventSummaries, Stream payload) { }

}

