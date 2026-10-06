namespace System.Linq.Expressions.Interpreter;

internal class MethodInfoCallInstruction : CallInstruction
{
	protected readonly MethodInfo _target; //Field offset: 0x10
	protected readonly int _argumentCount; //Field offset: 0x18

	public virtual int ArgumentCount
	{
		 get { } //Length: 4
	}

	public virtual int ProducedStack
	{
		 get { } //Length: 162
	}

	internal MethodInfoCallInstruction(MethodInfo target, int argumentCount) { }

	public virtual int get_ArgumentCount() { }

	public virtual int get_ProducedStack() { }

	protected Object[] GetArgs(InterpretedFrame frame, int first, int skip) { }

	public virtual int Run(InterpretedFrame frame) { }

	public virtual string ToString() { }

}

