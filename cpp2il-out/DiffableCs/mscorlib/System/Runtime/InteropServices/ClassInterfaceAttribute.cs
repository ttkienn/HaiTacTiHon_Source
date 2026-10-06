namespace System.Runtime.InteropServices;

[AttributeUsage(5, Inherited = False)]
[ComVisible(True)]
public sealed class ClassInterfaceAttribute : Attribute
{
	internal ClassInterfaceType _val; //Field offset: 0x10

	public ClassInterfaceAttribute(ClassInterfaceType classInterfaceType) { }

}

