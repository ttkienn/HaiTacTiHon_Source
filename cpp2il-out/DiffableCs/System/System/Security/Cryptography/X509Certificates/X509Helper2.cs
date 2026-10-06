namespace System.Security.Cryptography.X509Certificates;

internal static class X509Helper2
{

	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	internal static Exception GetInvalidChainContextException() { }

	[MonoTODO("Investigate replacement; see comments in source.")]
	internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	public static bool IsValid(X509ChainImpl impl) { }

	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

}

