namespace System.IO;

public sealed class FileInfo : FileSystemInfo
{

	public virtual string Name
	{
		 get { } //Length: 5
	}

	private FileInfo() { }

	public FileInfo(string fileName) { }

	internal FileInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false) { }

	private FileInfo(SerializationInfo info, StreamingContext context) { }

	public StreamWriter AppendText() { }

	public StreamWriter CreateText() { }

	public virtual string get_Name() { }

}

