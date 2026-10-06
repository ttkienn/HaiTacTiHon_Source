namespace System;

public sealed class TypeInitializationException : SystemException
{
	private string _typeName; //Field offset: 0x90

	public string TypeName
	{
		 get { } //Length: 83
	}

	private TypeInitializationException() { }

	public TypeInitializationException(string fullTypeName, Exception innerException) { }

	internal TypeInitializationException(string fullTypeName, string message, Exception innerException) { }

	internal TypeInitializationException(SerializationInfo info, StreamingContext context) { }

	public string get_TypeName() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

