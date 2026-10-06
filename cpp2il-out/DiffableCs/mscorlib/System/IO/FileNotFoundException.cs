namespace System.IO;

public class FileNotFoundException : IOException
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
		 get { } //Length: 215
	}

	public FileNotFoundException() { }

	public FileNotFoundException(string message) { }

	public FileNotFoundException(string message, string fileName) { }

	protected FileNotFoundException(SerializationInfo info, StreamingContext context) { }

	[CompilerGenerated]
	public string get_FileName() { }

	[CompilerGenerated]
	public string get_FusionLog() { }

	public virtual string get_Message() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void SetMessageField() { }

	public virtual string ToString() { }

}

