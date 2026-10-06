namespace System.ComponentModel;

public sealed class PropertyChangingEventHandler : MulticastDelegate
{

	public PropertyChangingEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, PropertyChangingEventArgs e) { }

}

