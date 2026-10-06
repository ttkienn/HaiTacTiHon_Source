namespace System.Xml.Linq;

public class XObjectChangeEventArgs : EventArgs
{
	public static readonly XObjectChangeEventArgs Add; //Field offset: 0x0
	public static readonly XObjectChangeEventArgs Remove; //Field offset: 0x8
	public static readonly XObjectChangeEventArgs Name; //Field offset: 0x10
	public static readonly XObjectChangeEventArgs Value; //Field offset: 0x18
	private XObjectChange _objectChange; //Field offset: 0x10

	private static XObjectChangeEventArgs() { }

	public XObjectChangeEventArgs(XObjectChange objectChange) { }

}

