namespace Unity.Services.Core.Internal.Serialization;

internal class NewtonsoftSerializer : IJsonSerializer
{
	private readonly JsonSerializer m_Serializer; //Field offset: 0x10

	public NewtonsoftSerializer(JsonSerializerSettings settings = null) { }

	internal NewtonsoftSerializer(JsonSerializer serializer) { }

	public override T DeserializeObject(string value) { }

	public override string SerializeObject(T value) { }

}

