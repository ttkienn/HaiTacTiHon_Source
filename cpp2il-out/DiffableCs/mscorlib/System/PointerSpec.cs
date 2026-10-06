namespace System;

internal class PointerSpec : ModifierSpec
{
	private int pointer_level; //Field offset: 0x10

	internal PointerSpec(int pointer_level) { }

	public override StringBuilder Append(StringBuilder sb) { }

	public override Type Resolve(Type type) { }

	public virtual string ToString() { }

}

