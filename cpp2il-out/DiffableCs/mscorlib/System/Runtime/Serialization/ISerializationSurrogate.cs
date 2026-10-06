namespace System.Runtime.Serialization;

public interface ISerializationSurrogate
{

	public void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector) { }

}

