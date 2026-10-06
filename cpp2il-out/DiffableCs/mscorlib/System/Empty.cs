namespace System;

internal sealed class Empty : ISerializable
{
	public static readonly Empty Value; //Field offset: 0x0

	private static Empty() { }

	private Empty() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

