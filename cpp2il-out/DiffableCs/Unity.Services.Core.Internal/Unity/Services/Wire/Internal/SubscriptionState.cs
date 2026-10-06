namespace Unity.Services.Wire.Internal;

public enum SubscriptionState
{
	Unsubscribed = 0,
	Synced = 1,
	Unsynced = 2,
	Error = 3,
	Subscribing = 4,
}

