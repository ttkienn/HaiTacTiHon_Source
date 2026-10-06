namespace Newtonsoft.Json;

[AttributeUsage(3484, AllowMultiple = False)]
[Nullable(0)]
[NullableContext(1)]
public sealed class JsonConverterAttribute : Attribute
{
	private readonly Type _converterType; //Field offset: 0x10
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private readonly Object[] <ConverterParameters>k__BackingField; //Field offset: 0x18

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public Object[] ConverterParameters
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Type ConverterType
	{
		 get { } //Length: 5
	}

	public JsonConverterAttribute(Type converterType) { }

	public JsonConverterAttribute(Type converterType, Object[] converterParameters) { }

	[CompilerGenerated]
	public Object[] get_ConverterParameters() { }

	public Type get_ConverterType() { }

}

