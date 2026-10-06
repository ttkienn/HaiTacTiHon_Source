namespace System.Diagnostics.Tracing;

[AttributeUsage(AttributeTargets::Class (4))]
public sealed class EventSourceAttribute : Attribute
{
	[CompilerGenerated]
	private string <Guid>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x18

	public string Guid
	{
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public string Name
	{
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public EventSourceAttribute() { }

	[CompilerGenerated]
	public void set_Guid(string value) { }

	[CompilerGenerated]
	public void set_Name(string value) { }

}

