namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Field (256), Inherited = False)]
[ComVisible(True)]
public sealed class FieldOffsetAttribute : Attribute
{
	internal int _val; //Field offset: 0x10

	public FieldOffsetAttribute(int offset) { }

}

