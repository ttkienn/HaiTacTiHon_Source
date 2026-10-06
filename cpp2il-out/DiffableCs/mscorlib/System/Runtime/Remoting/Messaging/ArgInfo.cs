namespace System.Runtime.Remoting.Messaging;

internal class ArgInfo
{
	private Int32[] _paramMap; //Field offset: 0x10
	private int _inoutArgCount; //Field offset: 0x18
	private MethodBase _method; //Field offset: 0x20

	public ArgInfo(MethodBase method, ArgInfoType type) { }

	public Object[] GetInOutArgs(Object[] args) { }

}

