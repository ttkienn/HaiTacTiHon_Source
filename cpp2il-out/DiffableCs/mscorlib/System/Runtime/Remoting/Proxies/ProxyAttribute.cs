namespace System.Runtime.Remoting.Proxies;

[AttributeUsage(AttributeTargets::Class (4))]
[ComVisible(True)]
public class ProxyAttribute : Attribute, IContextAttribute
{

	public override MarshalByRefObject CreateInstance(Type serverType) { }

	public override RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext) { }

	[ComVisible(True)]
	public override void GetPropertiesForNewContext(IConstructionCallMessage msg) { }

	[ComVisible(True)]
	public override bool IsContextOK(Context ctx, IConstructionCallMessage msg) { }

}

