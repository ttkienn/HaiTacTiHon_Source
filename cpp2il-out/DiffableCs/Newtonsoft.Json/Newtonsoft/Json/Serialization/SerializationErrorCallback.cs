namespace Newtonsoft.Json.Serialization;

public sealed class SerializationErrorCallback : MulticastDelegate
{

	public SerializationErrorCallback(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(object o, StreamingContext context, ErrorContext errorContext, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	[NullableContext(1)]
	public override void Invoke(object o, StreamingContext context, ErrorContext errorContext) { }

}

