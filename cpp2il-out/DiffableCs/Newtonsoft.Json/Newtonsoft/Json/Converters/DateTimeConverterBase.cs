namespace Newtonsoft.Json.Converters;

public abstract class DateTimeConverterBase : JsonConverter
{

	protected DateTimeConverterBase() { }

	[NullableContext(1)]
	public virtual bool CanConvert(Type objectType) { }

}

