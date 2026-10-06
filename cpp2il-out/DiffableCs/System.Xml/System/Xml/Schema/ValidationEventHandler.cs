namespace System.Xml.Schema;

public sealed class ValidationEventHandler : MulticastDelegate
{

	public ValidationEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, ValidationEventArgs e) { }

}

