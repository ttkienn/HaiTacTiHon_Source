namespace UnityEngine.UIElements;

internal static class EventInterestReflectionUtils
{
	private struct DefaultEventInterests
	{
		public int DefaultActionCategories; //Field offset: 0x0
		public int DefaultActionAtTargetCategories; //Field offset: 0x4

	}

	private static readonly Dictionary<Type, DefaultEventInterests> s_DefaultEventInterests; //Field offset: 0x0
	private static readonly Dictionary<Type, EventCategory> s_EventCategories; //Field offset: 0x8

	private static EventInterestReflectionUtils() { }

	private static int ComputeDefaultEventInterests(Type elementType, string methodName) { }

	internal static void GetDefaultEventInterests(Type elementType, out int defaultActionCategories, out int defaultActionAtTargetCategories) { }

	internal static EventCategory GetEventCategory(Type eventType) { }

}

