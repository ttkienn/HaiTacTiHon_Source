namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
[Preserve]
internal class AppleFetchProductsService : IAppleFetchProductsService
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		[Nullable(0)]
		public AppleFetchProductsService <>4__this; //Field offset: 0x10
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public IReadOnlyCollection<ProductDefinition> products; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal Task<List`1<ProductDescription>> <FetchProducts>b__0() { }

	}

	[CompilerGenerated]
	private struct <ExecuteFetchProductsRequest>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(new IL2CPP_TYPE_U1[] {0, 0, 1}])]
		public AsyncTaskMethodBuilder<List`1<ProductDescription>> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public AppleFetchProductsService <>4__this; //Field offset: 0x20
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public IReadOnlyCollection<ProductDefinition> products; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		private TaskAwaiter<List`1<ProductDescription>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Nullable(2)]
	private INativeAppleStore m_NativeStore; //Field offset: 0x10
	[CompilerGenerated]
	[Nullable(2)]
	private string <LastRequestProductsJson>k__BackingField; //Field offset: 0x18
	private readonly TaskQueue queue; //Field offset: 0x20
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	private TaskCompletionSource<List`1<ProductDescription>> m_CurrentRequestCompletionSource; //Field offset: 0x28

	[Nullable(2)]
	public private override string LastRequestProductsJson
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
		[CompilerGenerated]
		[NullableContext(2)]
		private set { } //Length: 13
	}

	public AppleFetchProductsService() { }

	[AsyncStateMachine(typeof(<ExecuteFetchProductsRequest>d__10))]
	private Task<List`1<ProductDescription>> ExecuteFetchProductsRequest(IReadOnlyCollection<ProductDefinition> products) { }

	public override Task<List`1<ProductDescription>> FetchProducts(IReadOnlyCollection<ProductDefinition> products) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public override string get_LastRequestProductsJson() { }

	public override void OnProductDetailsRetrieveFailed(string errorMessage) { }

	public override void OnProductsFetched(string json) { }

	[CompilerGenerated]
	[NullableContext(2)]
	private void set_LastRequestProductsJson(string value) { }

	public override void SetNativeStore(INativeAppleStore nativeStore) { }

	private void ValidateThatRequestIsPossible() { }

}

