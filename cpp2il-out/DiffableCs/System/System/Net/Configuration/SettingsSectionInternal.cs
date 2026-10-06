namespace System.Net.Configuration;

internal sealed class SettingsSectionInternal
{
	private static readonly SettingsSectionInternal instance; //Field offset: 0x0
	internal readonly bool HttpListenerUnescapeRequestUrl; //Field offset: 0x10
	internal readonly IPProtectionLevel IPProtectionLevel; //Field offset: 0x14

	internal bool Ipv6Enabled
	{
		internal get { } //Length: 3
	}

	internal static SettingsSectionInternal Section
	{
		internal get { } //Length: 78
	}

	private static SettingsSectionInternal() { }

	public SettingsSectionInternal() { }

	internal bool get_Ipv6Enabled() { }

	internal static SettingsSectionInternal get_Section() { }

}

