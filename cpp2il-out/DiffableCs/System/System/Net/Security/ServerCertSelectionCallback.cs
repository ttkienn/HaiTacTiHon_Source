namespace System.Net.Security;

internal sealed class ServerCertSelectionCallback : MulticastDelegate
{

	public ServerCertSelectionCallback(object object, IntPtr method) { }

	public override X509Certificate Invoke(string hostName) { }

}

