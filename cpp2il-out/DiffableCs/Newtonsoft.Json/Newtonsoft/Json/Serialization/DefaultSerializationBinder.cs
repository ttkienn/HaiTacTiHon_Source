namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public class DefaultSerializationBinder : SerializationBinder, ISerializationBinder
{
	internal static readonly DefaultSerializationBinder Instance; //Field offset: 0x0
	[Nullable(new IL2CPP_TYPE_U1[] {1, 0, 2, 1, 1}])]
	private readonly ThreadSafeStore<StructMultiKey`2<String, String>, Type> _typeCache; //Field offset: 0x10

	private static DefaultSerializationBinder() { }

	public DefaultSerializationBinder() { }

	[NullableContext(2)]
	public virtual void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	public virtual Type BindToType(string assemblyName, string typeName) { }

	private Type GetGenericTypeFromTypeName(string typeName, Assembly assembly) { }

	private Type GetTypeByName(StructMultiKey<String, String> typeNameKey) { }

	private Type GetTypeFromTypeNameKey(StructMultiKey<String, String> typeNameKey) { }

}

