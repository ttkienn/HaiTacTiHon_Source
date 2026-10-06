namespace System.Linq.Expressions.Interpreter;

internal sealed class LocalVariables
{
	private sealed class VariableScope
	{
		public readonly int Start; //Field offset: 0x10
		public int Stop; //Field offset: 0x14
		public readonly LocalVariable Variable; //Field offset: 0x18
		public readonly VariableScope Parent; //Field offset: 0x20
		public List<VariableScope> ChildScopes; //Field offset: 0x28

		public VariableScope(LocalVariable variable, int start, VariableScope parent) { }

	}

	private readonly HybridReferenceDictionary<ParameterExpression, VariableScope> _variables; //Field offset: 0x10
	private Dictionary<ParameterExpression, LocalVariable> _closureVariables; //Field offset: 0x18
	private int _localCount; //Field offset: 0x20
	private int _maxLocalCount; //Field offset: 0x24

	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables
	{
		internal get { } //Length: 5
	}

	public int LocalCount
	{
		 get { } //Length: 4
	}

	public LocalVariables() { }

	internal LocalVariable AddClosureVariable(ParameterExpression variable) { }

	internal void Box(ParameterExpression variable, InstructionList instructions) { }

	public LocalDefinition DefineLocal(ParameterExpression variable, int start) { }

	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	public int get_LocalCount() { }

	public bool TryGetLocalOrClosure(ParameterExpression var, out LocalVariable local) { }

	public void UndefineLocal(LocalDefinition definition, int end) { }

}

