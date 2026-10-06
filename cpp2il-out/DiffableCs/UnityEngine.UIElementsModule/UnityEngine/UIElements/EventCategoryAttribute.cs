namespace UnityEngine.UIElements;

[AttributeUsage(AttributeTargets::Class (4))]
internal class EventCategoryAttribute : Attribute
{
	internal EventCategory category; //Field offset: 0x10

	public EventCategoryAttribute(EventCategory category) { }

}

