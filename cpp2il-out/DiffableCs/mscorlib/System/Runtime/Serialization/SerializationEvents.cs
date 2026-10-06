namespace System.Runtime.Serialization;

internal sealed class SerializationEvents
{
	private readonly List<MethodInfo> _onSerializingMethods; //Field offset: 0x10
	private readonly List<MethodInfo> _onSerializedMethods; //Field offset: 0x18
	private readonly List<MethodInfo> _onDeserializingMethods; //Field offset: 0x20
	private readonly List<MethodInfo> _onDeserializedMethods; //Field offset: 0x28

	internal bool HasOnSerializingEvents
	{
		internal get { } //Length: 19
	}

	internal SerializationEvents(Type t) { }

	private static SerializationEventHandler AddOnDelegate(object obj, SerializationEventHandler handler, List<MethodInfo> methods) { }

	internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler) { }

	internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler) { }

	internal bool get_HasOnSerializingEvents() { }

	private List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t) { }

	private static void InvokeOnDelegate(object obj, StreamingContext context, List<MethodInfo> methods) { }

	internal void InvokeOnDeserialized(object obj, StreamingContext context) { }

	internal void InvokeOnDeserializing(object obj, StreamingContext context) { }

	internal void InvokeOnSerializing(object obj, StreamingContext context) { }

}

