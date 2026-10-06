namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
public class Header
{
	public string HeaderNamespace; //Field offset: 0x10
	public bool MustUnderstand; //Field offset: 0x18
	public string Name; //Field offset: 0x20
	public object Value; //Field offset: 0x28

}

