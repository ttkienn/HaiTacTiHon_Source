namespace System.ComponentModel;

public sealed class PropertyChangedEventHandler : MulticastDelegate
{

	public PropertyChangedEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, PropertyChangedEventArgs e) { }

}

