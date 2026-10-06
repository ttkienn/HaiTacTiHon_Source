namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(2)]
internal class GoogleOrderInfo : OrderInfo, IGoogleOrderInfo
{
	[CompilerGenerated]
	private string <ObfuscatedAccountId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <ObfuscatedProfileId>k__BackingField; //Field offset: 0x30

	public override string ObfuscatedAccountId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public override string ObfuscatedProfileId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public GoogleOrderInfo(string receipt, string transactionID, string storeName, string obfuscatedAccountId, string obfuscatedProfileId) { }

	[CompilerGenerated]
	public override string get_ObfuscatedAccountId() { }

	[CompilerGenerated]
	public override string get_ObfuscatedProfileId() { }

	[CompilerGenerated]
	public override void set_ObfuscatedAccountId(string value) { }

	[CompilerGenerated]
	public override void set_ObfuscatedProfileId(string value) { }

}

