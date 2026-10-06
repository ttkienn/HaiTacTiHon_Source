namespace UnityEngine.Purchasing;

internal class FileReference
{
	private readonly string m_FilePath; //Field offset: 0x10
	private readonly ILogger m_Logger; //Field offset: 0x18

	internal FileReference(string filePath, ILogger logger) { }

	internal static FileReference CreateInstance(string filename, ILogger logger, IUtil util) { }

	internal void Delete() { }

	internal string Load() { }

	internal void Save(string payload) { }

}

