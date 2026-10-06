namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
public class StringEnumConverter : JsonConverter
{
	[CompilerGenerated]
	[Nullable(2)]
	private NamingStrategy <NamingStrategy>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <AllowIntegerValues>k__BackingField; //Field offset: 0x18

	public bool AllowIntegerValues
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[Obsolete("StringEnumConverter.CamelCaseText is obsolete. Set StringEnumConverter.NamingStrategy with CamelCaseNamingStrategy instead.")]
	public bool CamelCaseText
	{
		 get { } //Length: 105
		 set { } //Length: 209
	}

	[Nullable(2)]
	public NamingStrategy NamingStrategy
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
		[CompilerGenerated]
		[NullableContext(2)]
		 set { } //Length: 13
	}

	public StringEnumConverter() { }

	[Obsolete("StringEnumConverter(bool) is obsolete. Create a converter with StringEnumConverter(NamingStrategy, bool) instead.")]
	public StringEnumConverter(bool camelCaseText) { }

	public StringEnumConverter(NamingStrategy namingStrategy, bool allowIntegerValues = true) { }

	public StringEnumConverter(Type namingStrategyType) { }

	public StringEnumConverter(Type namingStrategyType, Object[] namingStrategyParameters) { }

	public StringEnumConverter(Type namingStrategyType, Object[] namingStrategyParameters, bool allowIntegerValues) { }

	public virtual bool CanConvert(Type objectType) { }

	[CompilerGenerated]
	public bool get_AllowIntegerValues() { }

	public bool get_CamelCaseText() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public NamingStrategy get_NamingStrategy() { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[CompilerGenerated]
	public void set_AllowIntegerValues(bool value) { }

	public void set_CamelCaseText(bool value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public void set_NamingStrategy(NamingStrategy value) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

