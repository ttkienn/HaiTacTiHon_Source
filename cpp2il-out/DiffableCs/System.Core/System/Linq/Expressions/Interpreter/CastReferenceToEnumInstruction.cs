namespace System.Linq.Expressions.Interpreter;

internal sealed class CastReferenceToEnumInstruction : CastInstruction
{
	private readonly Type _t; //Field offset: 0x10

	public CastReferenceToEnumInstruction(Type t) { }

	public virtual int Run(InterpretedFrame frame) { }

}

