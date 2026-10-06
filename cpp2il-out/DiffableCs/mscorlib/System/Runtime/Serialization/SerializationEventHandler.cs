namespace System.Runtime.Serialization;

public sealed class SerializationEventHandler : MulticastDelegate
{

	public SerializationEventHandler(object object, IntPtr method) { }

	public override void Invoke(StreamingContext context) { }

}

