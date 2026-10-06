namespace Unity.Services.Analytics.Internal;

internal interface IDispatcherDebug
{

	public event Action<Int32, Boolean, Boolean, Boolean, Boolean, Byte[]> FlushFinished
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<Byte[]> FlushStarted
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool FlushInProgress
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_FlushFinished(Action<Int32, Boolean, Boolean, Boolean, Boolean, Byte[]> value) { }

	[CompilerGenerated]
	public void add_FlushStarted(Action<Byte[]> value) { }

	public bool get_FlushInProgress() { }

	[CompilerGenerated]
	public void remove_FlushFinished(Action<Int32, Boolean, Boolean, Boolean, Boolean, Byte[]> value) { }

	[CompilerGenerated]
	public void remove_FlushStarted(Action<Byte[]> value) { }

}

