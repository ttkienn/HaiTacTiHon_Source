namespace System.Runtime.CompilerServices;

public sealed class RuntimeWrappedException : Exception
{
	private object _wrappedException; //Field offset: 0x90

	public object WrappedException
	{
		 get { } //Length: 8
	}

	public RuntimeWrappedException(object thrownObject) { }

	private RuntimeWrappedException(SerializationInfo info, StreamingContext context) { }

	internal RuntimeWrappedException() { }

	public object get_WrappedException() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

