namespace System.Linq.Expressions.Interpreter;

internal sealed class CastToEnumInstruction : CastInstruction
{
	private readonly Type _t; //Field offset: 0x10

	public CastToEnumInstruction(Type t) { }

	public virtual int Run(InterpretedFrame frame) { }

}

