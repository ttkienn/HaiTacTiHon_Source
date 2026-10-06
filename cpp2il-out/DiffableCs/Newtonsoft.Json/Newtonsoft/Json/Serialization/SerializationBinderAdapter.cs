namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
internal class SerializationBinderAdapter : ISerializationBinder
{
	public readonly SerializationBinder SerializationBinder; //Field offset: 0x10

	public SerializationBinderAdapter(SerializationBinder serializationBinder) { }

	[NullableContext(2)]
	public override void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	public override Type BindToType(string assemblyName, string typeName) { }

}

