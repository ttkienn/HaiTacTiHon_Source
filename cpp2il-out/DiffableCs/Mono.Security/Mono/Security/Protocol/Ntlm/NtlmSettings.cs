namespace Mono.Security.Protocol.Ntlm;

public static class NtlmSettings
{
	private static NtlmAuthLevel defaultAuthLevel; //Field offset: 0x0

	public static NtlmAuthLevel DefaultAuthLevel
	{
		 get { } //Length: 77
	}

	private static NtlmSettings() { }

	public static NtlmAuthLevel get_DefaultAuthLevel() { }

}

