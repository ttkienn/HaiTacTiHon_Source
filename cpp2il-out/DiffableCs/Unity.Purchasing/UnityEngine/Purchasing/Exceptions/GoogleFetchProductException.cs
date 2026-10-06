namespace UnityEngine.Purchasing.Exceptions;

internal class GoogleFetchProductException : FetchProductsException
{
	[CompilerGenerated]
	private readonly GoogleFetchProductsFailureReason <FailureReason>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private readonly GoogleBillingResponseCode <ResponseCode>k__BackingField; //Field offset: 0x9C

	private GoogleFetchProductsFailureReason FailureReason
	{
		[CompilerGenerated]
		private get { } //Length: 7
	}

	private GoogleBillingResponseCode ResponseCode
	{
		[CompilerGenerated]
		private get { } //Length: 7
	}

	[NullableContext(1)]
	public GoogleFetchProductException(GoogleFetchProductsFailureReason failureReason, GoogleBillingResponseCode responseCode, ProductFetchFailureDescription failureDescription) { }

	[CompilerGenerated]
	private GoogleFetchProductsFailureReason get_FailureReason() { }

	[CompilerGenerated]
	private GoogleBillingResponseCode get_ResponseCode() { }

}

