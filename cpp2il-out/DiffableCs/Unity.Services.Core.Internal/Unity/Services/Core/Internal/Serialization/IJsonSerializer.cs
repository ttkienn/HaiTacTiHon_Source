namespace Unity.Services.Core.Internal.Serialization;

internal interface IJsonSerializer
{

	public T DeserializeObject(string value) { }

	public string SerializeObject(T value) { }

}

