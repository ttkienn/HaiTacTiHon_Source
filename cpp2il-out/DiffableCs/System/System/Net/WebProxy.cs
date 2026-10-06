namespace System.Net;

public class WebProxy : IWebProxy, ISerializable
{
	private bool _UseRegistry; //Field offset: 0x10
	private bool _BypassOnLocal; //Field offset: 0x11
	private bool m_EnableAutoproxy; //Field offset: 0x12
	private Uri _ProxyAddress; //Field offset: 0x18
	private ArrayList _BypassList; //Field offset: 0x20
	private ICredentials _Credentials; //Field offset: 0x28
	private Regex[] _RegExBypassList; //Field offset: 0x30
	private Hashtable _ProxyHostAddresses; //Field offset: 0x38
	private AutoWebProxyScriptEngine m_ScriptEngine; //Field offset: 0x40

	public override ICredentials Credentials
	{
		 get { } //Length: 5
	}

	internal AutoWebProxyScriptEngine ScriptEngine
	{
		internal get { } //Length: 5
	}

	public bool UseDefaultCredentials
	{
		 get { } //Length: 105
		 set { } //Length: 114
	}

	public WebProxy() { }

	public WebProxy(Uri Address, bool BypassOnLocal, String[] BypassList, ICredentials Credentials) { }

	internal WebProxy(bool enableAutoproxy) { }

	protected WebProxy(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private static bool AreAllBypassed(IEnumerable<String> proxies, bool checkFirstOnly) { }

	public static IWebProxy CreateDefaultProxy() { }

	public override ICredentials get_Credentials() { }

	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	public bool get_UseDefaultCredentials() { }

	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public override Uri GetProxy(Uri destination) { }

	private bool GetProxyAuto(Uri destination, out Uri proxyUri) { }

	public override bool IsBypassed(Uri host) { }

	private bool IsBypassedAuto(Uri destination, out bool isBypassed) { }

	private bool IsBypassedManual(Uri host) { }

	private bool IsLocal(Uri host) { }

	private bool IsLocalInProxyHash(Uri host) { }

	private bool IsMatchInBypassList(Uri input) { }

	private static Uri ProxyUri(string proxyName) { }

	public void set_UseDefaultCredentials(bool value) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	internal void UnsafeUpdateFromRegistry() { }

	private void UpdateRegExList(bool canThrow) { }

}

