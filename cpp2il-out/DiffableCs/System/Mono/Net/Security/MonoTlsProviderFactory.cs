namespace Mono.Net.Security;

internal static class MonoTlsProviderFactory
{
	private static object locker; //Field offset: 0x0
	private static bool initialized; //Field offset: 0x8
	private static MobileTlsProvider defaultProvider; //Field offset: 0x10
	private static Dictionary<String, Tuple`2<Guid, String>> providerRegistration; //Field offset: 0x18
	private static Dictionary<Guid, MobileTlsProvider> providerCache; //Field offset: 0x20
	internal static readonly Guid UnityTlsId; //Field offset: 0x28
	internal static readonly Guid AppleTlsId; //Field offset: 0x38
	internal static readonly Guid BtlsId; //Field offset: 0x48

	private static MonoTlsProviderFactory() { }

	private static MobileTlsProvider CreateDefaultProviderImpl() { }

	internal static MobileTlsProvider GetProvider() { }

	internal static MobileTlsProvider GetProviderInternal() { }

	internal static void InitializeInternal() { }

	private static void InitializeProviderRegistration() { }

	internal static bool IsBtlsSupported() { }

	private static MobileTlsProvider LookupProvider(string name, bool throwOnError) { }

	private static void PopulateProviders() { }

	private static void PopulateUnityProviders() { }

}

