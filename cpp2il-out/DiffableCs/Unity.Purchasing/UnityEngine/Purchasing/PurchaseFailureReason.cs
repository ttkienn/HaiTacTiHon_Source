namespace UnityEngine.Purchasing;

public enum PurchaseFailureReason
{
	PurchasingUnavailable = 0,
	ExistingPurchasePending = 1,
	ProductUnavailable = 2,
	SignatureInvalid = 3,
	UserCancelled = 4,
	PaymentDeclined = 5,
	DuplicateTransaction = 6,
	ValidationFailure = 7,
	StoreNotConnected = 8,
	PurchaseMissing = 9,
	Unknown = 10,
}

