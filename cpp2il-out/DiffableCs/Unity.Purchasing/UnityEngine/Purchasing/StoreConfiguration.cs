namespace UnityEngine.Purchasing;

internal class StoreConfiguration
{
	[CompilerGenerated]
	private AppStore <androidStore>k__BackingField; //Field offset: 0x10

	public private AppStore androidStore
	{
		[CompilerGenerated]
		 get { } //Length: 191
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public StoreConfiguration(AppStore store) { }

	public static StoreConfiguration Deserialize(string json) { }

	[CompilerGenerated]
	public AppStore get_androidStore() { }

	public static string Serialize(StoreConfiguration store) { }

	[CompilerGenerated]
	private void set_androidStore(AppStore value) { }

}

