namespace System.Reflection;

public sealed class ReflectionTypeLoadException : SystemException, ISerializable
{
	[CompilerGenerated]
	private readonly Type[] <Types>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private readonly Exception[] <LoaderExceptions>k__BackingField; //Field offset: 0x98

	public Exception[] LoaderExceptions
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public virtual string Message
	{
		 get { } //Length: 10
	}

	public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions) { }

	private ReflectionTypeLoadException(SerializationInfo info, StreamingContext context) { }

	private string CreateString(bool isMessage) { }

	[CompilerGenerated]
	public Exception[] get_LoaderExceptions() { }

	public virtual string get_Message() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

