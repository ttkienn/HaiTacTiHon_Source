namespace Newtonsoft.Json.Serialization;

public sealed class SerializationCallback : MulticastDelegate
{

	public SerializationCallback(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(object o, StreamingContext context, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	[NullableContext(1)]
	public override void Invoke(object o, StreamingContext context) { }

}

