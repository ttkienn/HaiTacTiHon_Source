namespace System.Diagnostics.Tracing;

[AttributeUsage(AttributeTargets::Method (64))]
public sealed class EventAttribute : Attribute
{
	[CompilerGenerated]
	private int <EventId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private EventLevel <Level>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private EventKeywords <Keywords>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Message>k__BackingField; //Field offset: 0x20

	private int EventId
	{
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public EventKeywords Keywords
	{
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public EventLevel Level
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string Message
	{
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public EventAttribute(int eventId) { }

	[CompilerGenerated]
	private void set_EventId(int value) { }

	[CompilerGenerated]
	public void set_Keywords(EventKeywords value) { }

	[CompilerGenerated]
	public void set_Level(EventLevel value) { }

	[CompilerGenerated]
	public void set_Message(string value) { }

}

