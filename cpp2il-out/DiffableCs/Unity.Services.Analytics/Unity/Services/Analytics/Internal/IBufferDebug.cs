namespace Unity.Services.Analytics.Internal;

internal interface IBufferDebug
{

	public event Action<String, String, DateTime, Byte[]> EventRecorded
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<HashSet`1<String>> EventsCleared
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<HashSet`1<String>> EventsClearing
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_EventRecorded(Action<String, String, DateTime, Byte[]> value) { }

	[CompilerGenerated]
	public void add_EventsCleared(Action<HashSet`1<String>> value) { }

	[CompilerGenerated]
	public void add_EventsClearing(Action<HashSet`1<String>> value) { }

	[CompilerGenerated]
	public void remove_EventRecorded(Action<String, String, DateTime, Byte[]> value) { }

	[CompilerGenerated]
	public void remove_EventsCleared(Action<HashSet`1<String>> value) { }

	[CompilerGenerated]
	public void remove_EventsClearing(Action<HashSet`1<String>> value) { }

}

