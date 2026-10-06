namespace System;

[ComVisible(True)]
public class TypeLoadException : SystemException, ISerializable
{
	private string ClassName; //Field offset: 0x90
	private string AssemblyName; //Field offset: 0x98
	private string MessageArg; //Field offset: 0xA0
	internal int ResourceId; //Field offset: 0xA8

	public virtual string Message
	{
		 get { } //Length: 26
	}

	public TypeLoadException() { }

	public TypeLoadException(string message) { }

	private TypeLoadException(string className, string assemblyName) { }

	private TypeLoadException(string className, string assemblyName, string messageArg, int resourceId) { }

	protected TypeLoadException(SerializationInfo info, StreamingContext context) { }

	public virtual string get_Message() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void SetMessageField() { }

}

