namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
internal class RootFilter : PathFilter
{
	public static readonly RootFilter Instance; //Field offset: 0x0

	private static RootFilter() { }

	private RootFilter() { }

	public virtual IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

}

