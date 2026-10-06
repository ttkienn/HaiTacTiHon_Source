namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public class CamelCasePropertyNamesContractResolver : DefaultContractResolver
{
	private static readonly object TypeContractCacheLock; //Field offset: 0x0
	private static readonly DefaultJsonNameTable NameTable; //Field offset: 0x8
	[Nullable(new IL2CPP_TYPE_U1[] {2, 0, 1, 1, 1}])]
	private static Dictionary<StructMultiKey`2<Type, Type>, JsonContract> _contractCache; //Field offset: 0x10

	private static CamelCasePropertyNamesContractResolver() { }

	public CamelCasePropertyNamesContractResolver() { }

	internal virtual DefaultJsonNameTable GetNameTable() { }

	public virtual JsonContract ResolveContract(Type type) { }

}

