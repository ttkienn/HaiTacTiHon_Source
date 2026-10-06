namespace System.Linq.Expressions.Interpreter;

internal interface IBoxableInstruction
{

	public Instruction BoxIfIndexMatches(int index) { }

}

