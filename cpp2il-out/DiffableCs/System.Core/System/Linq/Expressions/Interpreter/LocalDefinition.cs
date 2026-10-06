namespace System.Linq.Expressions.Interpreter;

[IsReadOnly]
internal struct LocalDefinition
{
	[CompilerGenerated]
	private readonly int <Index>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly ParameterExpression <Parameter>k__BackingField; //Field offset: 0x8

	public int Index
	{
		[CompilerGenerated]
		 get { } //Length: 3
	}

	public ParameterExpression Parameter
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal LocalDefinition(int localIndex, ParameterExpression parameter) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public int get_Index() { }

	[CompilerGenerated]
	public ParameterExpression get_Parameter() { }

	public virtual int GetHashCode() { }

}

