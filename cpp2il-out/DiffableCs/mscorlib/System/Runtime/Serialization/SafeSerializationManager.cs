namespace System.Runtime.Serialization;

internal sealed class SafeSerializationManager : IObjectReference, ISerializable
{
	private IList<Object> m_serializedStates; //Field offset: 0x10
	private SerializationInfo m_savedSerializationInfo; //Field offset: 0x18
	private object m_realObject; //Field offset: 0x20
	private RuntimeType m_realType; //Field offset: 0x28
	[CompilerGenerated]
	private EventHandler<SafeSerializationEventArgs> SerializeObjectState; //Field offset: 0x30

	internal bool IsActive
	{
		internal get { } //Length: 9
	}

	internal SafeSerializationManager() { }

	private SafeSerializationManager(SerializationInfo info, StreamingContext context) { }

	internal void CompleteDeserialization(object deserializedObject) { }

	internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context) { }

	internal bool get_IsActive() { }

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context) { }

	private override object System.Runtime.Serialization.IObjectReference.GetRealObject(StreamingContext context) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

