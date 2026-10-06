namespace System.Runtime.Serialization;

public sealed class SerializationObjectManager
{
	private readonly Dictionary<Object, Object> _objectSeenTable; //Field offset: 0x10
	private readonly StreamingContext _context; //Field offset: 0x18
	private SerializationEventHandler _onSerializedHandler; //Field offset: 0x28

	public SerializationObjectManager(StreamingContext context) { }

	private void AddOnSerialized(object obj) { }

	public void RaiseOnSerializedEvent() { }

	public void RegisterObject(object obj) { }

}

