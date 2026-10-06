namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
internal class BooleanQueryExpression : QueryExpression
{
	public readonly object Left; //Field offset: 0x18
	[Nullable(2)]
	public readonly object Right; //Field offset: 0x20

	public BooleanQueryExpression(QueryOperator operator, object left, object right) { }

	internal static bool EqualsWithStrictMatch(JValue value, JValue queryValue) { }

	internal static bool EqualsWithStringCoercion(JValue value, JValue queryValue) { }

	private IEnumerable<JToken> GetResult(JToken root, JToken t, object o) { }

	public virtual bool IsMatch(JToken root, JToken t, JsonSelectSettings settings) { }

	private bool MatchTokens(JToken leftResult, JToken rightResult, JsonSelectSettings settings) { }

	private static bool RegexEquals(JValue input, JValue pattern, JsonSelectSettings settings) { }

}

