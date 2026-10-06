namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
internal class CompositeExpression : QueryExpression
{
	[CompilerGenerated]
	private List<QueryExpression> <Expressions>k__BackingField; //Field offset: 0x18

	public List<QueryExpression> Expressions
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public CompositeExpression(QueryOperator operator) { }

	[CompilerGenerated]
	public List<QueryExpression> get_Expressions() { }

	public virtual bool IsMatch(JToken root, JToken t, JsonSelectSettings settings) { }

	[CompilerGenerated]
	public void set_Expressions(List<QueryExpression> value) { }

}

