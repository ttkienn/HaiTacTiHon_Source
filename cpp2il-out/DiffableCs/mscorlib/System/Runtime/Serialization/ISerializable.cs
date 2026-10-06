namespace System.Runtime.Serialization;

public interface ISerializable
{

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

