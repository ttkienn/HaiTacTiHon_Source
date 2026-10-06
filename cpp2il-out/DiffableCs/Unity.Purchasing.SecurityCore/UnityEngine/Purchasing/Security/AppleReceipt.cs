namespace UnityEngine.Purchasing.Security;

public class AppleReceipt
{
	[CompilerGenerated]
	private string <bundleID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <appVersion>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private DateTime <expirationDate>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Byte[] <opaque>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Byte[] <hash>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <originalApplicationVersion>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private DateTime <receiptCreationDate>k__BackingField; //Field offset: 0x40
	public AppleInAppPurchaseReceipt[] inAppPurchaseReceipts; //Field offset: 0x48

	public internal string appVersion
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	public internal string bundleID
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	public internal DateTime expirationDate
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	public internal Byte[] hash
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	public internal Byte[] opaque
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	public internal string originalApplicationVersion
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	public internal DateTime receiptCreationDate
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	public AppleReceipt() { }

	[CompilerGenerated]
	public string get_appVersion() { }

	[CompilerGenerated]
	public string get_bundleID() { }

	[CompilerGenerated]
	public DateTime get_expirationDate() { }

	[CompilerGenerated]
	public Byte[] get_hash() { }

	[CompilerGenerated]
	public Byte[] get_opaque() { }

	[CompilerGenerated]
	public string get_originalApplicationVersion() { }

	[CompilerGenerated]
	public DateTime get_receiptCreationDate() { }

	[CompilerGenerated]
	internal void set_appVersion(string value) { }

	[CompilerGenerated]
	internal void set_bundleID(string value) { }

	[CompilerGenerated]
	internal void set_expirationDate(DateTime value) { }

	[CompilerGenerated]
	internal void set_hash(Byte[] value) { }

	[CompilerGenerated]
	internal void set_opaque(Byte[] value) { }

	[CompilerGenerated]
	internal void set_originalApplicationVersion(string value) { }

	[CompilerGenerated]
	internal void set_receiptCreationDate(DateTime value) { }

}

