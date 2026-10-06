namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(2)]
internal class AppleOrderInfo : OrderInfo, IAppleOrderInfo
{
	[Nullable(1)]
	private IAppleAppReceiptViewer m_ReceiptViewer; //Field offset: 0x28
	[CompilerGenerated]
	private string <OriginalTransactionID>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private OwnershipType <OwnershipType>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[Nullable(1)]
	private string <StoreName>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private Nullable<Guid> <AppAccountToken>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private string <jwsRepresentation>k__BackingField; //Field offset: 0x60

	public override Nullable<Guid> AppAccountToken
	{
		[CompilerGenerated]
		 get { } //Length: 17
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public override string AppReceipt
	{
		 get { } //Length: 70
	}

	public override string jwsRepresentation
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public override string OriginalTransactionID
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public override OwnershipType OwnershipType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[Nullable(1)]
	public override string StoreName
	{
		[CompilerGenerated]
		[NullableContext(1)]
		 get { } //Length: 5
		[CompilerGenerated]
		[NullableContext(1)]
		 set { } //Length: 13
	}

	[NullableContext(1)]
	public AppleOrderInfo(string transactionID, string storeName, IAppleAppReceiptViewer appReceiptViewer, string originalTransactionID, OwnershipType ownershipType, Nullable<Guid> appAccountToken, string signatureJws) { }

	[CompilerGenerated]
	public override Nullable<Guid> get_AppAccountToken() { }

	public override string get_AppReceipt() { }

	[CompilerGenerated]
	public override string get_jwsRepresentation() { }

	[CompilerGenerated]
	public override string get_OriginalTransactionID() { }

	[CompilerGenerated]
	public override OwnershipType get_OwnershipType() { }

	[CompilerGenerated]
	[NullableContext(1)]
	public override string get_StoreName() { }

	[CompilerGenerated]
	public override void set_AppAccountToken(Nullable<Guid> value) { }

	[CompilerGenerated]
	public override void set_jwsRepresentation(string value) { }

	[CompilerGenerated]
	public override void set_OriginalTransactionID(string value) { }

	[CompilerGenerated]
	public override void set_OwnershipType(OwnershipType value) { }

	[CompilerGenerated]
	[NullableContext(1)]
	public override void set_StoreName(string value) { }

}

