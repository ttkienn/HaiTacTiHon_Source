namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
public interface IMethodMessage : IMessage
{

	public int ArgCount
	{
		 get { } //Length: 0
	}

	public Object[] Args
	{
		 get { } //Length: 0
	}

	public LogicalCallContext LogicalCallContext
	{
		 get { } //Length: 0
	}

	public MethodBase MethodBase
	{
		 get { } //Length: 0
	}

	public string MethodName
	{
		 get { } //Length: 0
	}

	public object MethodSignature
	{
		 get { } //Length: 0
	}

	public string TypeName
	{
		 get { } //Length: 0
	}

	public string Uri
	{
		 get { } //Length: 0
	}

	public int get_ArgCount() { }

	public Object[] get_Args() { }

	public LogicalCallContext get_LogicalCallContext() { }

	public MethodBase get_MethodBase() { }

	public string get_MethodName() { }

	public object get_MethodSignature() { }

	public string get_TypeName() { }

	public string get_Uri() { }

	public object GetArg(int argNum) { }

}

