namespace System.Linq.Expressions.Interpreter;

internal sealed class LocalVariable
{
	public readonly int Index; //Field offset: 0x10
	private int _flags; //Field offset: 0x14

	public bool InClosure
	{
		 get { } //Length: 8
	}

	public bool IsBoxed
	{
		 get { } //Length: 8
		 set { } //Length: 25
	}

	internal LocalVariable(int index, bool closure) { }

	public bool get_InClosure() { }

	public bool get_IsBoxed() { }

	public void set_IsBoxed(bool value) { }

	public virtual string ToString() { }

}

