namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
internal class JPath
{
	private static readonly Char[] FloatCharacters; //Field offset: 0x0
	private readonly string _expression; //Field offset: 0x10
	[CompilerGenerated]
	private readonly List<PathFilter> <Filters>k__BackingField; //Field offset: 0x18
	private int _currentIndex; //Field offset: 0x20

	public List<PathFilter> Filters
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static JPath() { }

	public JPath(string expression) { }

	private static PathFilter CreatePathFilter(string member, bool scan) { }

	private JsonException CreateUnexpectedCharacterException() { }

	private void EatWhitespace() { }

	private void EnsureLength(string message) { }

	internal IEnumerable<JToken> Evaluate(JToken root, JToken t, JsonSelectSettings settings) { }

	internal static IEnumerable<JToken> Evaluate(List<PathFilter> filters, JToken root, JToken t, JsonSelectSettings settings) { }

	[CompilerGenerated]
	public List<PathFilter> get_Filters() { }

	private bool Match(string s) { }

	private PathFilter ParseArrayIndexer(char indexerCloseChar) { }

	private QueryExpression ParseExpression() { }

	private PathFilter ParseIndexer(char indexerOpenChar, bool scan) { }

	private void ParseMain() { }

	private QueryOperator ParseOperator() { }

	private bool ParsePath(List<PathFilter> filters, int currentPartStartIndex, bool query) { }

	private PathFilter ParseQuery(char indexerCloseChar, bool scan) { }

	private PathFilter ParseQuotedField(char indexerCloseChar, bool scan) { }

	private object ParseSide() { }

	private string ReadQuotedString() { }

	private string ReadRegexString() { }

	private bool TryParseExpression(out List<PathFilter>& expressionPath) { }

	[NullableContext(2)]
	private bool TryParseValue(out object value) { }

}

