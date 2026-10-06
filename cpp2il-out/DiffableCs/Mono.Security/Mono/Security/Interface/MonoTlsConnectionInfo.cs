namespace Mono.Security.Interface;

public class MonoTlsConnectionInfo
{
	[CompilerGenerated]
	private CipherSuiteCode <CipherSuiteCode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private TlsProtocols <ProtocolVersion>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private string <PeerDomainName>k__BackingField; //Field offset: 0x18

	[CLSCompliant(False)]
	public CipherSuiteCode CipherSuiteCode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string PeerDomainName
	{
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public TlsProtocols ProtocolVersion
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public MonoTlsConnectionInfo() { }

	[CompilerGenerated]
	public CipherSuiteCode get_CipherSuiteCode() { }

	[CompilerGenerated]
	public TlsProtocols get_ProtocolVersion() { }

	[CompilerGenerated]
	public void set_CipherSuiteCode(CipherSuiteCode value) { }

	[CompilerGenerated]
	public void set_PeerDomainName(string value) { }

	[CompilerGenerated]
	public void set_ProtocolVersion(TlsProtocols value) { }

	public virtual string ToString() { }

}

