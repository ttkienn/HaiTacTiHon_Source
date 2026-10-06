namespace System.Linq.Expressions.Interpreter;

internal sealed class QuoteInstruction : Instruction
{
	private sealed class ExpressionQuoter : ExpressionVisitor
	{
		private readonly Dictionary<ParameterExpression, LocalVariable> _variables; //Field offset: 0x10
		private readonly InterpretedFrame _frame; //Field offset: 0x18
		private readonly Stack<HashSet`1<ParameterExpression>> _shadowedVars; //Field offset: 0x20

		internal ExpressionQuoter(Dictionary<ParameterExpression, LocalVariable> hoistedVariables, InterpretedFrame frame) { }

		private IStrongBox GetBox(ParameterExpression variable) { }

		protected private virtual Expression VisitBlock(BlockExpression node) { }

		protected virtual CatchBlock VisitCatchBlock(CatchBlock node) { }

		protected private virtual Expression VisitLambda(Expression<T> node) { }

		protected private virtual Expression VisitParameter(ParameterExpression node) { }

	}

	private readonly Expression _operand; //Field offset: 0x10
	private readonly Dictionary<ParameterExpression, LocalVariable> _hoistedVariables; //Field offset: 0x18

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	public virtual int ProducedStack
	{
		 get { } //Length: 6
	}

	public QuoteInstruction(Expression operand, Dictionary<ParameterExpression, LocalVariable> hoistedVariables) { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}

