namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryMethodCall
{
	private string methodName; //Field offset: 0x10
	private string typeName; //Field offset: 0x18
	private Object[] args; //Field offset: 0x20
	private object callContext; //Field offset: 0x28
	private Type[] argTypes; //Field offset: 0x30
	private bool bArgsPrimitive; //Field offset: 0x38
	private MessageEnum messageEnum; //Field offset: 0x3C

	public BinaryMethodCall() { }

	internal void Dump() { }

	internal void Write(__BinaryWriter sout) { }

}

