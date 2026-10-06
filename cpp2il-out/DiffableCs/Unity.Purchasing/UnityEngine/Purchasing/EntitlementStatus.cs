namespace UnityEngine.Purchasing;

public enum EntitlementStatus
{
	Unknown = 0,
	NotEntitled = 1,
	EntitledUntilConsumed = 2,
	EntitledButNotFinished = 3,
	FullyEntitled = 4,
}

