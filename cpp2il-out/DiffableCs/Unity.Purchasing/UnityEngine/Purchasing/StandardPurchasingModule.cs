namespace UnityEngine.Purchasing;

[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
public class StandardPurchasingModule
{
	private static StandardPurchasingModule instance; //Field offset: 0x0
	[CompilerGenerated]
	private FakeStoreUIMode <useFakeStoreUIMode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <useFakeStoreAlways>k__BackingField; //Field offset: 0x14
	internal readonly string k_Version; //Field offset: 0x18

	public AppStore appStore
	{
		 get { } //Length: 64
	}

	public bool useFakeStoreAlways
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public FakeStoreUIMode useFakeStoreUIMode
	{
		[CompilerGenerated]
		 get { } //Length: 191
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string Version
	{
		 get { } //Length: 5
	}

	public StandardPurchasingModule() { }

	public AppStore get_appStore() { }

	[CompilerGenerated]
	public bool get_useFakeStoreAlways() { }

	[CompilerGenerated]
	public FakeStoreUIMode get_useFakeStoreUIMode() { }

	public string get_Version() { }

	public static StandardPurchasingModule Instance() { }

	public static StandardPurchasingModule Instance(AppStore androidStore) { }

	[CompilerGenerated]
	public void set_useFakeStoreAlways(bool value) { }

	[CompilerGenerated]
	public void set_useFakeStoreUIMode(FakeStoreUIMode value) { }

}

