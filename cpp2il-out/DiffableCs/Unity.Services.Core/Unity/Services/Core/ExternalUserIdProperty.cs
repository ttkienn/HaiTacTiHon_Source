namespace Unity.Services.Core;

internal class ExternalUserIdProperty
{
	[CompilerGenerated]
	private Action<String> UserIdChanged; //Field offset: 0x10
	private string m_UserId; //Field offset: 0x18

	public event Action<String> UserIdChanged
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public string UserId
	{
		 get { } //Length: 5
		 set { } //Length: 61
	}

	public ExternalUserIdProperty() { }

	[CompilerGenerated]
	public void add_UserIdChanged(Action<String> value) { }

	public string get_UserId() { }

	[CompilerGenerated]
	public void remove_UserIdChanged(Action<String> value) { }

	public void set_UserId(string value) { }

}

