namespace Unity.Services.Wire.Internal;

public interface IChannel : IDisposable
{

	public event Action<Byte[]> BinaryMessageReceived
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<String> ErrorReceived
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action KickReceived
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<String> MessageReceived
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<SubscriptionState> NewStateReceived
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_BinaryMessageReceived(Action<Byte[]> value) { }

	[CompilerGenerated]
	public void add_ErrorReceived(Action<String> value) { }

	[CompilerGenerated]
	public void add_KickReceived(Action value) { }

	[CompilerGenerated]
	public void add_MessageReceived(Action<String> value) { }

	[CompilerGenerated]
	public void add_NewStateReceived(Action<SubscriptionState> value) { }

	[CompilerGenerated]
	public void remove_BinaryMessageReceived(Action<Byte[]> value) { }

	[CompilerGenerated]
	public void remove_ErrorReceived(Action<String> value) { }

	[CompilerGenerated]
	public void remove_KickReceived(Action value) { }

	[CompilerGenerated]
	public void remove_MessageReceived(Action<String> value) { }

	[CompilerGenerated]
	public void remove_NewStateReceived(Action<SubscriptionState> value) { }

	public Task SubscribeAsync() { }

	public Task UnsubscribeAsync() { }

}

