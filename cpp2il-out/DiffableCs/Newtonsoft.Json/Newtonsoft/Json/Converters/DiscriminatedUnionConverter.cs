namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
public class DiscriminatedUnionConverter : JsonConverter
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public int tag; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		[NullableContext(0)]
		internal bool <WriteJson>b__0(UnionCase c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		[Nullable(0)]
		public string caseName; //Field offset: 0x10
		[Nullable(0)]
		public Func<UnionCase, Boolean> <>9__0; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		[NullableContext(0)]
		internal bool <ReadJson>b__0(UnionCase c) { }

	}

	[Nullable(0)]
	public class Union
	{
		public readonly FSharpFunction TagReader; //Field offset: 0x10
		public readonly List<UnionCase> Cases; //Field offset: 0x18

		public Union(FSharpFunction tagReader, List<UnionCase> cases) { }

	}

	[Nullable(0)]
	public class UnionCase
	{
		public readonly int Tag; //Field offset: 0x10
		public readonly string Name; //Field offset: 0x18
		public readonly PropertyInfo[] Fields; //Field offset: 0x20
		public readonly FSharpFunction FieldReader; //Field offset: 0x28
		public readonly FSharpFunction Constructor; //Field offset: 0x30

		public UnionCase(int tag, string name, PropertyInfo[] fields, FSharpFunction fieldReader, FSharpFunction constructor) { }

	}

	private const string CasePropertyName = "Case"; //Field offset: 0x0
	private const string FieldsPropertyName = "Fields"; //Field offset: 0x0
	private static readonly ThreadSafeStore<Type, Union> UnionCache; //Field offset: 0x0
	private static readonly ThreadSafeStore<Type, Type> UnionTypeLookupCache; //Field offset: 0x8

	private static DiscriminatedUnionConverter() { }

	public DiscriminatedUnionConverter() { }

	public virtual bool CanConvert(Type objectType) { }

	private static Union CreateUnion(Type t) { }

	private static Type CreateUnionTypeLookup(Type t) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

