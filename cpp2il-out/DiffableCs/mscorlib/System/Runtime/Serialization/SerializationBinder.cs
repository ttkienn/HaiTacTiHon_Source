namespace System.Runtime.Serialization;

public abstract class SerializationBinder
{

	protected SerializationBinder() { }

	public override void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	public abstract Type BindToType(string assemblyName, string typeName) { }

}

