namespace System;

internal class ArraySpec : ModifierSpec
{
	private int dimensions; //Field offset: 0x10
	private bool bound; //Field offset: 0x14

	internal ArraySpec(int dimensions, bool bound) { }

	public override StringBuilder Append(StringBuilder sb) { }

	public override Type Resolve(Type type) { }

	public virtual string ToString() { }

}

