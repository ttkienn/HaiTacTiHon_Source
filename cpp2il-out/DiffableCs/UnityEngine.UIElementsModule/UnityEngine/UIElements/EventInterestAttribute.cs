namespace UnityEngine.UIElements;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = True)]
public class EventInterestAttribute : Attribute
{
	internal Type[] eventTypes; //Field offset: 0x10
	internal EventCategoryFlags categoryFlags; //Field offset: 0x18

	public EventInterestAttribute(Type[] eventTypes) { }

	public EventInterestAttribute(EventInterestOptions interests) { }

}

