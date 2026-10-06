namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
internal abstract class QueryExpression
{
	internal QueryOperator Operator; //Field offset: 0x10

	public QueryExpression(QueryOperator operator) { }

	public bool IsMatch(JToken root, JToken t) { }

	public abstract bool IsMatch(JToken root, JToken t, JsonSelectSettings settings) { }

}

