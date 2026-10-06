namespace System.Runtime.Remoting;

[ComVisible(True)]
public static class RemotingConfiguration
{
	private static string applicationID; //Field offset: 0x0
	private static string applicationName; //Field offset: 0x8
	private static string processGuid; //Field offset: 0x10
	private static bool defaultConfigRead; //Field offset: 0x18
	private static bool defaultDelayedConfigRead; //Field offset: 0x19
	private static CustomErrorsModes _errorMode; //Field offset: 0x1C
	private static Hashtable wellKnownClientEntries; //Field offset: 0x20
	private static Hashtable activatedClientEntries; //Field offset: 0x28
	private static Hashtable wellKnownServiceEntries; //Field offset: 0x30
	private static Hashtable activatedServiceEntries; //Field offset: 0x38
	private static Hashtable channelTemplates; //Field offset: 0x40
	private static Hashtable clientProviderTemplates; //Field offset: 0x48
	private static Hashtable serverProviderTemplates; //Field offset: 0x50

	public static string ApplicationName
	{
		 get { } //Length: 79
		 set { } //Length: 110
	}

	public static string ProcessId
	{
		 get { } //Length: 219
	}

	private static RemotingConfiguration() { }

	public static bool CustomErrorsEnabled(bool isLocalRequest) { }

	public static string get_ApplicationName() { }

	public static string get_ProcessId() { }

	public static bool IsActivationAllowed(Type svrType) { }

	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType) { }

	public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType) { }

	internal static void LoadDefaultDelayedChannels() { }

	public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry) { }

	public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry) { }

	internal static void RegisterChannels(ArrayList channels, bool onlyDelayed) { }

	internal static void RegisterChannelTemplate(ChannelData channel) { }

	internal static void RegisterClientProviderTemplate(ProviderData prov) { }

	internal static void RegisterServerProviderTemplate(ProviderData prov) { }

	internal static void RegisterTypes(ArrayList types) { }

	public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry) { }

	public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry) { }

	public static void set_ApplicationName(string value) { }

	internal static void SetCustomErrorsMode(string mode) { }

}

