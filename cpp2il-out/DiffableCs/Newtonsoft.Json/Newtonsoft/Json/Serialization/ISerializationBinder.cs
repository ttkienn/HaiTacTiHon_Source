namespace Newtonsoft.Json.Serialization;

[NullableContext(1)]
public interface ISerializationBinder
{

	[NullableContext(2)]
	public void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	public Type BindToType(string assemblyName, string typeName) { }

}

