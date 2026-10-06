namespace UnityEngine.Purchasing;

[NullableContext(2)]
public interface IAppleOrderInfo
{

	public Nullable<Guid> AppAccountToken
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string AppReceipt
	{
		 get { } //Length: 0
	}

	public string jwsRepresentation
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string OriginalTransactionID
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public OwnershipType OwnershipType
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	[Nullable(1)]
	public string StoreName
	{
		[NullableContext(1)]
		 get { } //Length: 0
		[NullableContext(1)]
		 set { } //Length: 0
	}

	public Nullable<Guid> get_AppAccountToken() { }

	public string get_AppReceipt() { }

	public string get_jwsRepresentation() { }

	public string get_OriginalTransactionID() { }

	public OwnershipType get_OwnershipType() { }

	[NullableContext(1)]
	public string get_StoreName() { }

	public void set_AppAccountToken(Nullable<Guid> value) { }

	public void set_jwsRepresentation(string value) { }

	public void set_OriginalTransactionID(string value) { }

	public void set_OwnershipType(OwnershipType value) { }

	[NullableContext(1)]
	public void set_StoreName(string value) { }

}

