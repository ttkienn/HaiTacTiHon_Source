namespace System.Runtime.Remoting.Messaging;

internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage
{
	private RuntimeMethodInfo method; //Field offset: 0x10
	private Object[] args; //Field offset: 0x18
	private String[] names; //Field offset: 0x20
	private Byte[] arg_types; //Field offset: 0x28
	public LogicalCallContext ctx; //Field offset: 0x30
	public object rval; //Field offset: 0x38
	public Exception exc; //Field offset: 0x40
	private AsyncResult asyncResult; //Field offset: 0x48
	private CallType call_type; //Field offset: 0x50
	private string uri; //Field offset: 0x58
	private MCMDictionary properties; //Field offset: 0x60
	private Identity identity; //Field offset: 0x68
	private Type[] methodSignature; //Field offset: 0x70

	public override int ArgCount
	{
		 get { } //Length: 144
	}

	public override Object[] Args
	{
		 get { } //Length: 5
	}

	public AsyncResult AsyncResult
	{
		 get { } //Length: 5
	}

	internal CallType CallType
	{
		internal get { } //Length: 108
	}

	public override Exception Exception
	{
		 get { } //Length: 5
	}

	public override LogicalCallContext LogicalCallContext
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public override MethodBase MethodBase
	{
		 get { } //Length: 5
	}

	public override string MethodName
	{
		 get { } //Length: 117
	}

	public override object MethodSignature
	{
		 get { } //Length: 325
	}

	public override int OutArgCount
	{
		 get { } //Length: 94
	}

	public override Object[] OutArgs
	{
		 get { } //Length: 408
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

	public override string TypeName
	{
		 get { } //Length: 144
	}

	public override string Uri
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public MonoMethodMessage(MethodBase method, Object[] out_args) { }

	internal MonoMethodMessage(MethodInfo minfo, Object[] in_args, Object[] out_args) { }

	public MonoMethodMessage(Type type, string methodName, Object[] in_args) { }

	public override int get_ArgCount() { }

	public override Object[] get_Args() { }

	public AsyncResult get_AsyncResult() { }

	internal CallType get_CallType() { }

	public override Exception get_Exception() { }

	public override LogicalCallContext get_LogicalCallContext() { }

	public override MethodBase get_MethodBase() { }

	public override string get_MethodName() { }

	public override object get_MethodSignature() { }

	public override int get_OutArgCount() { }

	public override Object[] get_OutArgs() { }

	public override IDictionary get_Properties() { }

	public override object get_ReturnValue() { }

	public override string get_TypeName() { }

	public override string get_Uri() { }

	public override object GetArg(int arg_num) { }

	private static MethodInfo GetMethodInfo(Type type, string methodName) { }

	internal void InitMessage(RuntimeMethodInfo method, Object[] out_args) { }

	public bool NeedsOutProcessing(out int outCount) { }

	public void set_LogicalCallContext(LogicalCallContext value) { }

	public override void set_Uri(string value) { }

	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	private override void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

}

