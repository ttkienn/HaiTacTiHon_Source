namespace System.Runtime.Remoting.Messaging;

[CLSCompliant(False)]
[ComVisible(True)]
public class ConstructionResponse : MethodResponse, IConstructionReturnMessage, IMethodReturnMessage, IMethodMessage, IMessage
{

	public virtual IDictionary Properties
	{
		 get { } //Length: 187
	}

	internal ConstructionResponse(object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	internal ConstructionResponse(Exception e, IMethodCallMessage msg) { }

	internal ConstructionResponse(SerializationInfo info, StreamingContext context) { }

	public virtual IDictionary get_Properties() { }

}

