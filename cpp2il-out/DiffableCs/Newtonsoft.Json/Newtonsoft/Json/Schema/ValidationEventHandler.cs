namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public sealed class ValidationEventHandler : MulticastDelegate
{

	public ValidationEventHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(object sender, ValidationEventArgs e, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(object sender, ValidationEventArgs e) { }

}

