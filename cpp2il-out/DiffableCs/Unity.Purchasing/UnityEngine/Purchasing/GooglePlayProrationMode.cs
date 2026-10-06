namespace UnityEngine.Purchasing;

[Obsolete("Use GooglePlayReplacementMode instead.")]
public enum GooglePlayProrationMode
{
	UnknownSubscriptionUpgradeDowngradePolicy = 0,
	ImmediateWithTimeProration = 1,
	ImmediateAndChargeProratedPrice = 2,
	ImmediateWithoutProration = 3,
	Deferred = 6,
	ImmediateAndChargeFullPrice = 5,
}

