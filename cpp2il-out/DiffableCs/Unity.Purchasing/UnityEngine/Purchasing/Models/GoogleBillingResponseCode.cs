namespace UnityEngine.Purchasing.Models;

internal enum GoogleBillingResponseCode
{
	ServiceTimeout = -3,
	FeatureNotSupported = -2,
	ServiceDisconnected = -1,
	Ok = 0,
	UserCanceled = 1,
	ServiceUnavailable = 2,
	BillingUnavailable = 3,
	ItemUnavailable = 4,
	DeveloperError = 5,
	FatalError = 6,
	ItemAlreadyOwned = 7,
	ItemNotOwned = 8,
	NetworkError = 12,
}

