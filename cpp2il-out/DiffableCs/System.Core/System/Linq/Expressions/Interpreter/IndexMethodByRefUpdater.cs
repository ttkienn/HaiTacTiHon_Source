namespace System.Linq.Expressions.Interpreter;

internal sealed class IndexMethodByRefUpdater : ByRefUpdater
{
	private readonly MethodInfo _indexer; //Field offset: 0x18
	private readonly Nullable<LocalDefinition> _obj; //Field offset: 0x20
	private readonly LocalDefinition[] _args; //Field offset: 0x38

	public IndexMethodByRefUpdater(Nullable<LocalDefinition> obj, LocalDefinition[] args, MethodInfo indexer, int argumentIndex) { }

	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }

	public virtual void Update(InterpretedFrame frame, object value) { }

}

