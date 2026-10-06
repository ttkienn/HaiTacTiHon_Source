namespace System.IO;

public class DriveNotFoundException : IOException
{

	public DriveNotFoundException() { }

	public DriveNotFoundException(string message) { }

	protected DriveNotFoundException(SerializationInfo info, StreamingContext context) { }

}

