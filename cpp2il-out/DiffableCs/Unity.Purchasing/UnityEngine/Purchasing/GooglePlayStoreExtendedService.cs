namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class GooglePlayStoreExtendedService : StoreService, IGooglePlayStoreExtendedService, IStoreServiceExtension
{
	[Nullable(2)]
	private Action m_InitializationConnectionListener; //Field offset: 0x18
	private readonly IGooglePlayStoreSetObfuscatedIdUseCase m_GooglePlayStoreSetObfuscatedIdUseCase; //Field offset: 0x20
	private readonly IGooglePlayStoreConnectionUseCase m_GooglePlayStoreConnectionUseCase; //Field offset: 0x28

	[Preserve]
	internal GooglePlayStoreExtendedService(IGooglePlayStoreSetObfuscatedIdUseCase googlePlayStoreSetObfuscatedIdUseCase, IGooglePlayStoreConnectionUseCase googlePlayStoreConnectionUseCase, IStoreConnectUseCase connectUseCase) { }

	public override void EndConnection() { }

	public void NotifyInitializationConnectionFailed() { }

	[NullableContext(2)]
	public void SetInitializeConnectionFailureListener(Action listener) { }

	public override void SetObfuscatedAccountId(string accountId) { }

	public override void SetObfuscatedProfileId(string profileId) { }

}

