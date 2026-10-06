namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
public class RemotingSurrogateSelector : ISurrogateSelector
{
	private static Type s_cachedTypeObjRef; //Field offset: 0x0
	private static ObjRefSurrogate _objRefSurrogate; //Field offset: 0x8
	private static RemotingSurrogate _objRemotingSurrogate; //Field offset: 0x10
	private ISurrogateSelector _next; //Field offset: 0x10

	private static RemotingSurrogateSelector() { }

	public RemotingSurrogateSelector() { }

	public override ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout) { }

}

