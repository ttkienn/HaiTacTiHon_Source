namespace System.IO;

public class FileLoadException : IOException
{
	[CompilerGenerated]
	private readonly string <FileName>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private readonly string <FusionLog>k__BackingField; //Field offset: 0x98

	public string FileName
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public string FusionLog
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public virtual string Message
	{
		 get { } //Length: 141
	}

	public FileLoadException() { }

	public FileLoadException(string message) { }

	protected FileLoadException(SerializationInfo info, StreamingContext context) { }

	internal static string FormatFileLoadExceptionMessage(string fileName, int hResult) { }

	[CompilerGenerated]
	public string get_FileName() { }

	[CompilerGenerated]
	public string get_FusionLog() { }

	public virtual string get_Message() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

