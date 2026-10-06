namespace UnityEngine.Purchasing;

internal class CheckEntitlementUseCase : ICheckEntitlementUseCase, IStoreCheckEntitlementCallback
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Product productToCheckFor; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <FindExistingEntitlementRequest>b__0(CheckEntitlementRequest request) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public ProductDefinition productDefinition; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal bool <GetMatchingRequest>b__0(CheckEntitlementRequest request) { }

	}

	private readonly IStore m_Store; //Field offset: 0x10
	private readonly List<CheckEntitlementRequest> m_OngoingRequests; //Field offset: 0x18

	[Preserve]
	internal CheckEntitlementUseCase(IStore storeResponsible) { }

	private void AddAndSendCheckEntitlementRequest(Product product, Action<Entitlement> onCheckComplete) { }

	private bool FindExistingEntitlementRequest(Product productToCheckFor) { }

	private CheckEntitlementRequest GetMatchingRequest(ProductDefinition productDefinition) { }

	public override void IsProductEntitled(Product product, Action<Entitlement> onResult) { }

	public override void OnCheckEntitlement(ProductDefinition productDefinition, EntitlementStatus status, string message = null) { }

}

