namespace System.Linq.Expressions.Interpreter;

internal sealed class FieldByRefUpdater : ByRefUpdater
{
	private readonly Nullable<LocalDefinition> _object; //Field offset: 0x18
	private readonly FieldInfo _field; //Field offset: 0x30

	public FieldByRefUpdater(Nullable<LocalDefinition> obj, FieldInfo field, int argumentIndex) { }

	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }

	public virtual void Update(InterpretedFrame frame, object value) { }

}

