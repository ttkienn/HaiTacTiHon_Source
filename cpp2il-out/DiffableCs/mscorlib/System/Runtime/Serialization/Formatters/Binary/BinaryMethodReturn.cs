namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryMethodReturn
{
	private static object instanceOfVoid; //Field offset: 0x0
	private object returnValue; //Field offset: 0x10
	private Object[] args; //Field offset: 0x18
	private object callContext; //Field offset: 0x20
	private Type[] argTypes; //Field offset: 0x28
	private bool bArgsPrimitive; //Field offset: 0x30
	private MessageEnum messageEnum; //Field offset: 0x34
	private Type returnType; //Field offset: 0x38

	private static BinaryMethodReturn() { }

	internal BinaryMethodReturn() { }

	public void Dump() { }

	public override void Write(__BinaryWriter sout) { }

}

