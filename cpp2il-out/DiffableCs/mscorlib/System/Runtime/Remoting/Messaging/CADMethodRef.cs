namespace System.Runtime.Remoting.Messaging;

internal class CADMethodRef
{
	private bool ctor; //Field offset: 0x10
	private string typeName; //Field offset: 0x18
	private string methodName; //Field offset: 0x20
	private String[] param_names; //Field offset: 0x28
	private String[] generic_arg_names; //Field offset: 0x30

	public CADMethodRef(IMethodMessage msg) { }

	private Type[] GetTypes(String[] typeArray) { }

	public MethodBase Resolve() { }

}

