namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
public class UnixDateTimeConverter : DateTimeConverterBase
{
	internal static readonly DateTime UnixEpoch; //Field offset: 0x0
	[CompilerGenerated]
	private bool <AllowPreEpoch>k__BackingField; //Field offset: 0x10

	public bool AllowPreEpoch
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private static UnixDateTimeConverter() { }

	public UnixDateTimeConverter() { }

	public UnixDateTimeConverter(bool allowPreEpoch) { }

	[CompilerGenerated]
	public bool get_AllowPreEpoch() { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[CompilerGenerated]
	public void set_AllowPreEpoch(bool value) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

