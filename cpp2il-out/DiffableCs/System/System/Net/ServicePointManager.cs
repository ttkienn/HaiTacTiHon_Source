namespace System.Net;

public class ServicePointManager
{
	public class SPKey
	{
		private Uri uri; //Field offset: 0x10
		private Uri proxy; //Field offset: 0x18
		private bool use_connect; //Field offset: 0x20

		public bool UsesProxy
		{
			 get { } //Length: 80
		}

		public SPKey(Uri uri, Uri proxy, bool use_connect) { }

		public virtual bool Equals(object obj) { }

		public bool get_UsesProxy() { }

		public virtual int GetHashCode() { }

	}

	private static ConcurrentDictionary<SPKey, ServicePoint> servicePoints; //Field offset: 0x0
	private static ICertificatePolicy policy; //Field offset: 0x8
	private static int defaultConnectionLimit; //Field offset: 0x10
	private static int maxServicePointIdleTime; //Field offset: 0x14
	private static int maxServicePoints; //Field offset: 0x18
	private static int dnsRefreshTimeout; //Field offset: 0x1C
	private static bool _checkCRL; //Field offset: 0x20
	private static SecurityProtocolType _securityProtocol; //Field offset: 0x24
	private static bool expectContinue; //Field offset: 0x28
	private static bool useNagle; //Field offset: 0x29
	private static ServerCertValidationCallback server_cert_cb; //Field offset: 0x30
	private static bool tcp_keepalive; //Field offset: 0x38
	private static int tcp_keepalive_time; //Field offset: 0x3C
	private static int tcp_keepalive_interval; //Field offset: 0x40

	[MonoTODO("CRL checks not implemented")]
	public static bool CheckCertificateRevocationList
	{
		 get { } //Length: 79
	}

	public static int DnsRefreshTimeout
	{
		 get { } //Length: 78
	}

	public static SecurityProtocolType SecurityProtocol
	{
		 get { } //Length: 78
	}

	public static RemoteCertificateValidationCallback ServerCertificateValidationCallback
	{
		 get { } //Length: 132
	}

	internal static ServerCertValidationCallback ServerCertValidationCallback
	{
		internal get { } //Length: 79
	}

	private static ServicePointManager() { }

	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	public static bool get_CheckCertificateRevocationList() { }

	public static int get_DnsRefreshTimeout() { }

	public static SecurityProtocolType get_SecurityProtocol() { }

	public static RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	internal static void RemoveServicePoint(ServicePoint sp) { }

}

