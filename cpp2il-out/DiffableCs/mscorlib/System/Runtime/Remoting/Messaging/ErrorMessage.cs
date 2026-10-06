namespace System.Runtime.Remoting.Messaging;

internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage
{
	private string _uri; //Field offset: 0x10

	public override int ArgCount
	{
		 get { } //Length: 3
	}

	public override Object[] Args
	{
		 get { } //Length: 3
	}

	public override LogicalCallContext LogicalCallContext
	{
		 get { } //Length: 3
	}

	public override MethodBase MethodBase
	{
		 get { } //Length: 3
	}

	public override string MethodName
	{
		 get { } //Length: 44
	}

	public override object MethodSignature
	{
		 get { } //Length: 3
	}

	public override IDictionary Properties
	{
		 get { } //Length: 3
	}

	public override string TypeName
	{
		 get { } //Length: 44
	}

	public override string Uri
	{
		 get { } //Length: 5
	}

	public ErrorMessage() { }

	public override int get_ArgCount() { }

	public override Object[] get_Args() { }

	public override LogicalCallContext get_LogicalCallContext() { }

	public override MethodBase get_MethodBase() { }

	public override string get_MethodName() { }

	public override object get_MethodSignature() { }

	public override IDictionary get_Properties() { }

	public override string get_TypeName() { }

	public override string get_Uri() { }

	public override object GetArg(int arg_num) { }

}

