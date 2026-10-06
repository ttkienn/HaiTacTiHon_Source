namespace System.Reflection;

[ComVisible(True)]
public class LocalVariableInfo
{
	internal Type type; //Field offset: 0x10
	internal bool is_pinned; //Field offset: 0x18
	internal ushort position; //Field offset: 0x1A

	protected LocalVariableInfo() { }

	public virtual string ToString() { }

}

