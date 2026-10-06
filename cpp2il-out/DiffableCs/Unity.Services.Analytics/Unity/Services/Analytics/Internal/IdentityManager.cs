namespace Unity.Services.Analytics.Internal;

internal class IdentityManager : IIdentityManager
{
	internal const string k_UnityAnalyticsInstallationIdKey = "UnityAnalyticsInstallationId"; //Field offset: 0x0
	internal const string k_UnityAnalyticsUserIdKey = "UnityAnalyticsUserId"; //Field offset: 0x0
	private readonly IPlayerId m_PlayerId; //Field offset: 0x10
	private readonly IExternalUserId m_ExternalIdProvider; //Field offset: 0x18
	private readonly IPersistence m_Persistence; //Field offset: 0x20
	private bool m_Initialized; //Field offset: 0x28
	[CompilerGenerated]
	private string <UserId>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <InstallId>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private string <ExternalId>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <IsNewPlayer>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private Action OnPlayerChanged; //Field offset: 0x50

	public override event Action OnPlayerChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public private override string ExternalId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private override string InstallId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private override bool IsNewPlayer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override string PlayerId
	{
		 get { } //Length: 73
	}

	public private override string UserId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public IdentityManager(IInstallationId installId, IPlayerId playerId, IExternalUserId externalId, IPersistence persistence) { }

	[CompilerGenerated]
	public override void add_OnPlayerChanged(Action value) { }

	private void ExternalUserIdChanged(string newName) { }

	[CompilerGenerated]
	public override string get_ExternalId() { }

	[CompilerGenerated]
	public override string get_InstallId() { }

	[CompilerGenerated]
	public override bool get_IsNewPlayer() { }

	public override string get_PlayerId() { }

	[CompilerGenerated]
	public override string get_UserId() { }

	public override void Initialize() { }

	[CompilerGenerated]
	public override void remove_OnPlayerChanged(Action value) { }

	[CompilerGenerated]
	private void set_ExternalId(string value) { }

	[CompilerGenerated]
	private void set_InstallId(string value) { }

	[CompilerGenerated]
	private void set_IsNewPlayer(bool value) { }

	[CompilerGenerated]
	private void set_UserId(string value) { }

}

