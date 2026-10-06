namespace UnityEngine;

internal enum CollisionPairFlags
{
	RemovedShape = 1,
	RemovedOtherShape = 2,
	ActorPairHasFirstTouch = 4,
	ActorPairLostTouch = 8,
	InternalHasImpulses = 16,
	InternalContactsAreFlipped = 32,
}

