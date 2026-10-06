namespace UnityEngine.Purchasing.Models;

internal class GoogleBillingResult : IGoogleBillingResult
{
	[CompilerGenerated]
	private readonly GoogleBillingResponseCode <responseCode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <debugMessage>k__BackingField; //Field offset: 0x18

	public override string debugMessage
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override GoogleBillingResponseCode responseCode
	{
		[CompilerGenerated]
		 get { } //Length: 191
	}

	internal GoogleBillingResult(AndroidJavaObject billingResult) { }

	[CompilerGenerated]
	public override string get_debugMessage() { }

	[CompilerGenerated]
	public override GoogleBillingResponseCode get_responseCode() { }

}

