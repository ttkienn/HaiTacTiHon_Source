namespace UnityEngine.Purchasing.Security;

public class GooglePlayReceipt : IPurchaseReceipt
{
	[CompilerGenerated]
	private string <productID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <orderID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <packageName>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <purchaseToken>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private DateTime <purchaseDate>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private GooglePurchaseState <purchaseState>k__BackingField; //Field offset: 0x38

	public private string orderID
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private string packageName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private override string productID
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private override DateTime purchaseDate
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private GooglePurchaseState purchaseState
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private string purchaseToken
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public override string transactionID
	{
		 get { } //Length: 5
	}

	public GooglePlayReceipt(string productID, string orderID, string packageName, string purchaseToken, DateTime purchaseTime, GooglePurchaseState purchaseState) { }

	[CompilerGenerated]
	public string get_orderID() { }

	[CompilerGenerated]
	public string get_packageName() { }

	[CompilerGenerated]
	public override string get_productID() { }

	[CompilerGenerated]
	public override DateTime get_purchaseDate() { }

	[CompilerGenerated]
	public GooglePurchaseState get_purchaseState() { }

	[CompilerGenerated]
	public string get_purchaseToken() { }

	public override string get_transactionID() { }

	[CompilerGenerated]
	private void set_orderID(string value) { }

	[CompilerGenerated]
	private void set_packageName(string value) { }

	[CompilerGenerated]
	private void set_productID(string value) { }

	[CompilerGenerated]
	private void set_purchaseDate(DateTime value) { }

	[CompilerGenerated]
	private void set_purchaseState(GooglePurchaseState value) { }

	[CompilerGenerated]
	private void set_purchaseToken(string value) { }

}

