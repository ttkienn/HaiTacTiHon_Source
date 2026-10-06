namespace System.Runtime.Serialization;

internal sealed class SurrogateForCyclicalReference : ISerializationSurrogate
{
	private ISerializationSurrogate innerSurrogate; //Field offset: 0x10

	public override void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	public override object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector) { }

}

