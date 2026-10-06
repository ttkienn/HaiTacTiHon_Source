namespace System;

public class DllNotFoundException : TypeLoadException
{

	public DllNotFoundException() { }

	public DllNotFoundException(string message) { }

	protected DllNotFoundException(SerializationInfo info, StreamingContext context) { }

}

