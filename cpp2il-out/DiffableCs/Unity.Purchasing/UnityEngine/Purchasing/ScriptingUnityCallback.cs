namespace UnityEngine.Purchasing;

internal class ScriptingUnityCallback : IUnityCallback
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public ScriptingUnityCallback <>4__this; //Field offset: 0x10
		public string jsonFailureDescription; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal void <OnStoreConnectionFailed>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public ScriptingUnityCallback <>4__this; //Field offset: 0x10
		public string json; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal void <OnProductsFetched>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public ScriptingUnityCallback <>4__this; //Field offset: 0x10
		public string jsonFailureDescription; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal void <OnProductsFetchFailed>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public ScriptingUnityCallback <>4__this; //Field offset: 0x10
		public string jsonFailureDescription; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal void <OnPurchasesRetrievalFailed>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public ScriptingUnityCallback <>4__this; //Field offset: 0x10
		public string json; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal void <OnPurchasesFetched>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public ScriptingUnityCallback <>4__this; //Field offset: 0x10
		public string id; //Field offset: 0x18
		public string receipt; //Field offset: 0x20
		public string transactionID; //Field offset: 0x28

		public <>c__DisplayClass7_0() { }

		internal void <OnPurchaseSucceeded>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public ScriptingUnityCallback <>4__this; //Field offset: 0x10
		public string json; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal void <OnPurchaseFailed>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public ScriptingUnityCallback <>4__this; //Field offset: 0x10
		public string json; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal void <OnPurchaseDeferred>b__0() { }

	}

	private readonly IUnityCallback forwardTo; //Field offset: 0x10
	private readonly IUtil util; //Field offset: 0x18

	public ScriptingUnityCallback(IUnityCallback forwardTo, IUtil util) { }

	[CompilerGenerated]
	private void <OnStoreConnectionSucceeded>b__10_0() { }

	public override void OnProductsFetched(string json) { }

	public override void OnProductsFetchFailed(string jsonFailureDescription) { }

	public override void OnPurchaseDeferred(string json) { }

	public override void OnPurchaseFailed(string json) { }

	public override void OnPurchasesFetched(string json) { }

	public override void OnPurchasesRetrievalFailed(string jsonFailureDescription) { }

	public override void OnPurchaseSucceeded(string id, string receipt, string transactionID) { }

	public override void OnStoreConnectionFailed(string jsonFailureDescription) { }

	public override void OnStoreConnectionSucceeded() { }

}

