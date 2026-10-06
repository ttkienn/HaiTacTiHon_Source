namespace Unity.Services.Analytics.Internal;

internal class FileSystemCalls : IFileSystemCalls
{
	private readonly bool m_CanAccessFileSystem; //Field offset: 0x10

	internal FileSystemCalls() { }

	public override bool CanAccessFileSystem() { }

	public override void DeleteFile(string path) { }

	public override bool FileExists(string path) { }

	public override Stream OpenFileForReading(string path) { }

	public override Stream OpenFileForWriting(string path) { }

}

