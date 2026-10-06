namespace Unity.Services.Core;

public interface IUnityServices
{

	public event Action Initialized
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<Exception> InitializeFailed
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public ServicesInitializationState State
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_Initialized(Action value) { }

	[CompilerGenerated]
	public void add_InitializeFailed(Action<Exception> value) { }

	public ServicesInitializationState get_State() { }

	public string GetIdentifier() { }

	public T GetService() { }

	public Task InitializeAsync(InitializationOptions options = null) { }

	[CompilerGenerated]
	public void remove_Initialized(Action value) { }

	[CompilerGenerated]
	public void remove_InitializeFailed(Action<Exception> value) { }

}

