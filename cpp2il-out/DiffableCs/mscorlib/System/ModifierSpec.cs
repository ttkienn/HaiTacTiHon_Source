namespace System;

internal interface ModifierSpec
{

	public StringBuilder Append(StringBuilder sb) { }

	public Type Resolve(Type type) { }

}

