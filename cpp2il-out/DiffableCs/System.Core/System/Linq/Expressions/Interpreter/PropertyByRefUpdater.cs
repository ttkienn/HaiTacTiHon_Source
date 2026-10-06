namespace System.Linq.Expressions.Interpreter;

internal sealed class PropertyByRefUpdater : ByRefUpdater
{
	private readonly Nullable<LocalDefinition> _object; //Field offset: 0x18
	private readonly PropertyInfo _property; //Field offset: 0x30

	public PropertyByRefUpdater(Nullable<LocalDefinition> obj, PropertyInfo property, int argumentIndex) { }

	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }

	public virtual void Update(InterpretedFrame frame, object value) { }

}

