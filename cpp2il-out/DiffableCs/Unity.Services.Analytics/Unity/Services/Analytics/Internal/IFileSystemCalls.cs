namespace Unity.Services.Analytics.Internal;

internal interface IFileSystemCalls
{

	public bool CanAccessFileSystem() { }

	public void DeleteFile(string path) { }

	public bool FileExists(string path) { }

	public Stream OpenFileForReading(string path) { }

	public Stream OpenFileForWriting(string path) { }

}

