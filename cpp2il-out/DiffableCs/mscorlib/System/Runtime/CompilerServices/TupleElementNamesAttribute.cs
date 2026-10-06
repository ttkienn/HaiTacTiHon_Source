namespace System.Runtime.CompilerServices;

[AttributeUsage(11148)]
[CLSCompliant(False)]
public sealed class TupleElementNamesAttribute : Attribute
{
	private readonly String[] _transformNames; //Field offset: 0x10

	public TupleElementNamesAttribute(String[] transformNames) { }

}

