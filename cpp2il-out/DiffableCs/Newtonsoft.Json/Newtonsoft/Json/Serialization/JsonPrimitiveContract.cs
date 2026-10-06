namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public class JsonPrimitiveContract : JsonContract
{
	private static readonly Dictionary<Type, ReadType> ReadTypeMap; //Field offset: 0x0
	[CompilerGenerated]
	private PrimitiveTypeCode <TypeCode>k__BackingField; //Field offset: 0x90

	internal PrimitiveTypeCode TypeCode
	{
		[CompilerGenerated]
		internal get { } //Length: 7
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	private static JsonPrimitiveContract() { }

	public JsonPrimitiveContract(Type underlyingType) { }

	[CompilerGenerated]
	internal PrimitiveTypeCode get_TypeCode() { }

	[CompilerGenerated]
	internal void set_TypeCode(PrimitiveTypeCode value) { }

}

