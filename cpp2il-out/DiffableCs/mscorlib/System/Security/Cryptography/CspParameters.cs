namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class CspParameters
{
	public int ProviderType; //Field offset: 0x10
	public string ProviderName; //Field offset: 0x18
	public string KeyContainerName; //Field offset: 0x20
	public int KeyNumber; //Field offset: 0x28
	private int m_flags; //Field offset: 0x2C

	public CspProviderFlags Flags
	{
		 get { } //Length: 4
		 set { } //Length: 231
	}

	public CspParameters() { }

	public CspParameters(int dwTypeIn) { }

	public CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) { }

	internal CspParameters(int providerType, string providerName, string keyContainerName, CspProviderFlags flags) { }

	public CspProviderFlags get_Flags() { }

	public void set_Flags(CspProviderFlags value) { }

}

