namespace UnityEngine.Purchasing;

internal class ProductDetailsQueryResponse : IProductDetailsQueryResponse
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<AndroidJavaObject, AndroidJavaObject> <>9__2_0; //Field offset: 0x8
		public static Func<ValueTuple`2<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>>, Boolean> <>9__3_0; //Field offset: 0x10
		public static Func<ValueTuple`2<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>>, IEnumerable`1<AndroidJavaObject>> <>9__3_1; //Field offset: 0x18
		public static Func<ValueTuple`2<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>>, IGoogleBillingResult> <>9__4_0; //Field offset: 0x20
		public static Func<ValueTuple`2<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>>, IGoogleBillingResult> <>9__5_0; //Field offset: 0x28
		public static Func<ValueTuple`2<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>>, IGoogleBillingResult> <>9__5_1; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal AndroidJavaObject <AddResponse>b__2_0(AndroidJavaObject product) { }

		internal IGoogleBillingResult <GetRecoverableBillingResponseCode>b__5_0(ValueTuple<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>> response) { }

		internal IGoogleBillingResult <GetRecoverableBillingResponseCode>b__5_1(ValueTuple<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>> response) { }

		internal IGoogleBillingResult <IsRecoverable>b__4_0(ValueTuple<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>> response) { }

		internal bool <ProductDetails>b__3_0(ValueTuple<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>> response) { }

		internal IEnumerable<AndroidJavaObject> <ProductDetails>b__3_1(ValueTuple<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>> response) { }

	}

	private readonly ConcurrentBag<ValueTuple`2<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>>> m_Responses; //Field offset: 0x10

	public ProductDetailsQueryResponse() { }

	public override void AddResponse(IGoogleBillingResult billingResult, IEnumerable<AndroidJavaObject> productDetails) { }

	protected virtual void Finalize() { }

	public override GoogleBillingResponseCode GetRecoverableBillingResponseCode() { }

	private static bool IsDeveloperError(IGoogleBillingResult billingResult) { }

	public override bool IsRecoverable() { }

	private static bool IsRecoverable(IGoogleBillingResult billingResult) { }

	private static bool IsServiceUnavailable(IGoogleBillingResult billingResult) { }

	public override List<AndroidJavaObject> ProductDetails() { }

}

