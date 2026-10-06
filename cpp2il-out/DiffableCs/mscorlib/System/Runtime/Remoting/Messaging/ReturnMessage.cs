namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage
{
	private Object[] _outArgs; //Field offset: 0x10
	private Object[] _args; //Field offset: 0x18
	private LogicalCallContext _callCtx; //Field offset: 0x20
	private object _returnValue; //Field offset: 0x28
	private string _uri; //Field offset: 0x30
	private Exception _exception; //Field offset: 0x38
	private MethodBase _methodBase; //Field offset: 0x40
	private string _methodName; //Field offset: 0x48
	private Type[] _methodSignature; //Field offset: 0x50
	private string _typeName; //Field offset: 0x58
	private MethodReturnDictionary _properties; //Field offset: 0x60
	private Identity _targetIdentity; //Field offset: 0x68
	private ArgInfo _inArgInfo; //Field offset: 0x70

	public override int ArgCount
	{
		 get { } //Length: 26
	}

	public override Object[] Args
	{
		 get { } //Length: 5
	}

	public override Exception Exception
	{
		 get { } //Length: 5
	}

	public override LogicalCallContext LogicalCallContext
	{
		 get { } //Length: 105
	}

	public override MethodBase MethodBase
	{
		 get { } //Length: 5
	}

	public override string MethodName
	{
		 get { } //Length: 93
	}

	public override object MethodSignature
	{
		 get { } //Length: 357
	}

	public override Object[] OutArgs
	{
		 get { } //Length: 182
	}

	public override IDictionary Properties
	{
		 get { } //Length: 109
	}

	public override object ReturnValue
	{
		 get { } //Length: 5
	}

	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
	{
		private get { } //Length: 5
		private set { } //Length: 13
	}

	private override string System.Runtime.Remoting.Messaging.IInternalMessage.Uri
	{
		private get { } //Length: 5
		private set { } //Length: 13
	}

	public override string TypeName
	{
		 get { } //Length: 121
	}

	public override string Uri
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public ReturnMessage(object ret, Object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	public ReturnMessage(Exception e, IMethodCallMessage mcm) { }

	public override int get_ArgCount() { }

	public override Object[] get_Args() { }

	public override Exception get_Exception() { }

	public override LogicalCallContext get_LogicalCallContext() { }

	public override MethodBase get_MethodBase() { }

	public override string get_MethodName() { }

	public override object get_MethodSignature() { }

	public override Object[] get_OutArgs() { }

	public override IDictionary get_Properties() { }

	public override object get_ReturnValue() { }

	public override string get_TypeName() { }

	public override string get_Uri() { }

	public override object GetArg(int argNum) { }

	public void set_Uri(string value) { }

	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	private override string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	private override void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	private override void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

}

