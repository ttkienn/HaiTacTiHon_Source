namespace System.Runtime.Remoting.Messaging;

internal class ObjRefSurrogate : ISerializationSurrogate
{

	public ObjRefSurrogate() { }

	public override void GetObjectData(object obj, SerializationInfo si, StreamingContext sc) { }

	public override object SetObjectData(object obj, SerializationInfo si, StreamingContext sc, ISurrogateSelector selector) { }

}

