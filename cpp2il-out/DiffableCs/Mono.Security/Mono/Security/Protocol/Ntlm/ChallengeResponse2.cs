namespace Mono.Security.Protocol.Ntlm;

public static class ChallengeResponse2
{
	private static Byte[] magic; //Field offset: 0x0
	private static Byte[] nullEncMagic; //Field offset: 0x8

	private static ChallengeResponse2() { }

	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out Byte[] lm, out Byte[] ntlm) { }

	private static Byte[] Compute_LM(string password, Byte[] challenge) { }

	private static Byte[] Compute_NTLM(string password, Byte[] challenge) { }

	private static Byte[] Compute_NTLM_Password(string password) { }

	private static Byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	private static void Compute_NTLMv2_Session(string password, Byte[] challenge, out Byte[] lm, out Byte[] ntlm) { }

	private static Byte[] GetResponse(Byte[] challenge, Byte[] pwd) { }

	private static Byte[] PasswordToKey(string password, int position) { }

	private static Byte[] PrepareDESKey(Byte[] key56bits, int position) { }

}

